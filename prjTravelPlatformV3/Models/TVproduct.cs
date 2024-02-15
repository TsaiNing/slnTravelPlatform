﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace prjTravelPlatformV3.Models;

public partial class TVproduct
{
    public int FId { get; set; }

    public int FCountryId { get; set; }

    public int FSupplierId { get; set; }

    public string FName { get; set; }

    public bool FNewOrLost { get; set; }

    public bool FInterviewRequirement { get; set; }

    public bool FEntityOrElectronic { get; set; }

    public int FProcessingTimeId { get; set; }

    public int FValidityPeriodId { get; set; }

    public int FLengthOfStayId { get; set; }

    public decimal FPrice { get; set; }

    public bool FEnabled { get; set; }

    public virtual TVcountry FCountry { get; set; }

    public virtual TVlengthOfStay FLengthOfStay { get; set; }

    public virtual TVprocessingTime FProcessingTime { get; set; }

    public virtual TCcompanyInfo FSupplier { get; set; }

    public virtual TVvalidityPeriod FValidityPeriod { get; set; }

    public virtual ICollection<TVorder> TVorders { get; set; } = new List<TVorder>();

    public virtual ICollection<TVproductFormsRequired> TVproductFormsRequireds { get; set; } = new List<TVproductFormsRequired>();
}