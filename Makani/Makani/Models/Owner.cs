using System;
using System.Collections.Generic;

namespace Makani;

public partial class Owner
{
    public int OwnerId { get; set; }

    public string Name { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public virtual ICollection<House> Houses { get; set; } = new List<House>();

}
