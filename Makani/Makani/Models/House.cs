using System;
using System.Collections.Generic;

namespace Makani;

public partial class House
{
    public int HouseId { get; set; }

    public string Location { get; set; } = null!;

    public decimal Price { get; set; }

    public string Description { get; set; } = null!;

    public string Status { get; set; } = null!;

    public int OwnerId { get; set; }

    public string Address { get; set; } = null!;

    public string Governorate { get; set; } = null!;

    public virtual Owner Owner { get; set; } = null!;

    public virtual ICollection<Picture> Pictures { get; set; } = new List<Picture>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
