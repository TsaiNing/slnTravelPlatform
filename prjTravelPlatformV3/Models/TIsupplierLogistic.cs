﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace prjTravelPlatformV3.Models;

public partial class TIsupplierLogistic
{
    public int FId { get; set; }

    public int? FSupplierId { get; set; }

    public int? FLogisticsId { get; set; }

    public virtual TIlogistic FLogistics { get; set; }

    public virtual TCcompanyInfo FSupplier { get; set; }
}