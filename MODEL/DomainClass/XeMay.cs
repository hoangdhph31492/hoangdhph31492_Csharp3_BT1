using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace hoangdhph31492_Csharp3_BT1.MODEL.DomainClass;

[Table("XeMay")]
public partial class XeMay
{
    [Key]
    public Guid Id { get; set; }

    [Column("MA")]
    [StringLength(20)]
    public string? Ma { get; set; }

    [Column("ten")]
    [StringLength(50)]
    public string? Ten { get; set; }

    [Column("SL")]
    public int? Sl { get; set; }

    [Column("MT")]
    [StringLength(50)]
    public string? Mt { get; set; }

    [Column("GIA")]
    public int? Gia { get; set; }

    [Column("idLSP")]
    public Guid? IdLsp { get; set; }

    [ForeignKey("IdLsp")]
    [InverseProperty("XeMays")]
    public virtual LoaiXm? IdLspNavigation { get; set; }
}
