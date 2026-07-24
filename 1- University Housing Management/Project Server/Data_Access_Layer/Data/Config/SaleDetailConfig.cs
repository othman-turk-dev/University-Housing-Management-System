using Data_Access_Layer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data_Access_Layer.Data.Config
{
    public class SaleDetailConfig : IEntityTypeConfiguration<SaleDetail>
    {
        public void Configure(EntityTypeBuilder<SaleDetail> builder)
        {
            builder.Property(e => e.SaleDetailId).HasColumnName("SaleDetailID");
            builder.Property(e => e.LineTotal).HasColumnType("smallmoney");
            builder.Property(e => e.ProductId)
                .HasMaxLength(50)
                .HasColumnName("ProductID");
            builder.Property(e => e.SaleId).HasColumnName("SaleID");
            builder.Property(e => e.UnitPrice).HasColumnType("smallmoney");

            builder.HasOne(d => d.Product).WithMany(p => p.SaleDetails)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleDetails_Products");

            builder.HasOne(d => d.Sale).WithMany(p => p.SaleDetails)
                .HasForeignKey(d => d.SaleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleDetails_Sales");
        }
    }
}
