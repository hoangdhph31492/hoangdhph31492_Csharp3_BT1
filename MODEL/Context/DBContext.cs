using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using hoangdhph31492_Csharp3_BT1.MODEL.DomainClass;

namespace hoangdhph31492_Csharp3_BT1.MODEL.Context;

public partial class DBContext : DbContext
{
    public DBContext()
    {
    }

    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<LoaiXm> LoaiXms { get; set; }

    public virtual DbSet<XeMay> XeMays { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=ADMIN;Initial Catalog=FINALASS_FPOLY_NET_JAVA_SM22_BL2;Integrated Security=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LoaiXm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LoaiXM__3214EC074344489F");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<XeMay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__XeMay__3214EC073ED3858A");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IdLspNavigation).WithMany(p => p.XeMays).HasConstraintName("FK_XeMay_LoaiXM");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
