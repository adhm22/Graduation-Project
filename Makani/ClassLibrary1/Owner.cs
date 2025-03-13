using System;
using System.Collections.Generic;

namespace ClassLibrary1;

public partial class Owner
{
    public int OwnerId { get; set; }

    public string Name { get; set; } = null!;

    public int UserId { get; set; }

    public string Phone { get; set; } = null!;

    public virtual ICollection<House> Houses { get; set; } = new List<House>();

    public virtual AspNetUser User { get; set; } = null!;
}
