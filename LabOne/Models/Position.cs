﻿using System;
using System.Collections.Generic;

namespace LabOne.Models;

public partial class Position
{
    public int PositionId { get; set; }

    public string PositionName { get; set; } = null!;

    public virtual ICollection<MovieCast> MovieCasts { get; } = new List<MovieCast>();
}
