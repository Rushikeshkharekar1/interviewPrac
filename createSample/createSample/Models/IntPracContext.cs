using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace createSample.Models;

public partial class IntPracContext : DbContext
{
    public IntPracContext()
    {
    }

    public IntPracContext(DbContextOptions<IntPracContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.Empid).HasName("PK__account__AF4CE865B72DE596");

            entity.ToTable("account");

            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Empname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("empname");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
