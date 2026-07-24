using Data_Access_Layer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data_Access_Layer.Data.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(e => e.ProductId)
            .HasMaxLength(50)
            .HasColumnName("ProductID");
            builder.Property(e => e.CreateByUserId).HasColumnName("CreateByUserID");
            builder.Property(e => e.CreateDate).HasColumnType("datetime");
            builder.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            builder.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            builder.Property(e => e.Price).HasColumnType("smallmoney");
            builder.Property(e => e.ProductName).HasMaxLength(250);
            builder.Property(e => e.PurchasePrice).HasColumnType("smallmoney");

            builder.HasOne(d => d.CreateByUser).WithMany(p => p.ProductCreateByUsers)
                .HasForeignKey(d => d.CreateByUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Products_Users");

            builder.HasOne(d => d.LastModifiedByUser).WithMany(p => p.ProductLastModifiedByUsers)
                .HasForeignKey(d => d.LastModifiedByUserId)
                .HasConstraintName("FK_Products_Users1");
        }
    }
}
