﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace prjTravelPlatformV3.Models;

public partial class TVformPath
{
    public int FId { get; set; }

    public string FFormName { get; set; }

    public string FFormPath { get; set; }

    public virtual ICollection<TVproductFormsRequired> TVproductFormsRequireds { get; set; } = new List<TVproductFormsRequired>();
}