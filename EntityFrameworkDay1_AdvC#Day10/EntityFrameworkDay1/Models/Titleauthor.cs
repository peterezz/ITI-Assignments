﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace EntityFrameworkDay1.Models;

public partial class Titleauthor
{
    public string AuId { get; set; }

    public string TitleId { get; set; }

    public byte? AuOrd { get; set; }

    public int? Royaltyper { get; set; }

    public virtual Author Au { get; set; }

    public virtual Title Title { get; set; }
}