using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace hoangdhph31492_Csharp3_BT1.MODEL.DomainClass;

[Table("LoaiXM")]
public partial class LoaiXm
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(50)]
    public string? Ten { get; set; }

    [InverseProperty("IdLspNavigation")]
    public virtual ICollection<XeMay> XeMays { get; set; } = new List<XeMay>();
}
