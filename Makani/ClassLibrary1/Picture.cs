﻿using System;
using System.Collections.Generic;

namespace ClassLibrary1;

public partial class Picture
{
    public int PictureId { get; set; }

    public string Url { get; set; } = null!;

    public bool Is360 { get; set; }

    public int HousesId { get; set; }

    public virtual House Houses { get; set; } = null!;
}
