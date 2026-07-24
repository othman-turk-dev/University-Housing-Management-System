using Data_Access_Layer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data_Access_Layer.Data.Config
{
    public class SpecializationConfig : IEntityTypeConfiguration<Specialization>
    {
        public void Configure(EntityTypeBuilder<Specialization> builder)
        {
            builder.HasKey(e => e.SpecializationId).HasName("PK_Specialization");

            builder.Property(e => e.SpecializationId).HasColumnName("SpecializationID");
            builder.Property(e => e.Name).HasMaxLength(250);
        }
    }
}
