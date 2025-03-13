using System;
using System.Collections.Generic;

namespace Makani;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string Name { get; set; } = null!;

    public string Phone { get; set; } = null!;


    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

}
