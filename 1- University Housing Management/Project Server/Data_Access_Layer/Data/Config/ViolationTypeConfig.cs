using Data_Access_Layer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data_Access_Layer.Data.Config
{
    public class ViolationTypeConfig : IEntityTypeConfiguration<ViolationType>
    {
        public void Configure(EntityTypeBuilder<ViolationType> builder)
        {
            builder.Property(e => e.ViolationTypeId).HasColumnName("ViolationTypeID");
            builder.Property(e => e.Name).HasMaxLength(250);
            builder.Property(e => e.PenaltyAmount).HasColumnType("smallmoney");
        }
    }
}
