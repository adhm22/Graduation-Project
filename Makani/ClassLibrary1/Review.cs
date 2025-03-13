using System;
using System.Collections.Generic;

namespace ClassLibrary1;

public partial class Review
{
    public int ReviewId { get; set; }

    public string Content { get; set; } = null!;

    public byte Rating { get; set; }

    public int CustomerId { get; set; }

    public int HouseId { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual House House { get; set; } = null!;
}
