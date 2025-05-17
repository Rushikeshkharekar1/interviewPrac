using System;
using System.Collections.Generic;

namespace createSample.Models;

public partial class Account
{
    public int Empid { get; set; }

    public string Empname { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;
}
