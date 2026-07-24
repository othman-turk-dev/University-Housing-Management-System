using Data_Access_Layer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data_Access_Layer.Data.Config
{
    public class SaleConfig : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.Property(e => e.SaleId).HasColumnName("SaleID");
            builder.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            builder.Property(e => e.Date).HasColumnType("datetime");

            builder.HasOne(d => d.CreatedByUser).WithMany(p => p.Sales)
                .HasForeignKey(d => d.CreatedByUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sales_Users");
        }
    }
}
