using Data_Access_Layer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data_Access_Layer.Data.Config
{
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(e => e.UniversityNumber);

            builder.Property(e => e.UniversityNumber).HasMaxLength(50);
            builder.Property(e => e.FullName).HasMaxLength(250);
            builder.Property(e => e.GuardiansNumber).HasMaxLength(20);
            builder.Property(e => e.Idphoto).HasColumnName("IDPhoto");
            builder.Property(e => e.Phone).HasMaxLength(20);
            builder.Property(e => e.RoomId).HasColumnName("RoomID");
            builder.Property(e => e.SpecilizationId).HasColumnName("SpecilizationID");

            builder.HasOne(d => d.Room).WithMany(p => p.Students)
                .HasForeignKey(d => d.RoomId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Students_Rooms");

            builder.HasOne(d => d.Specilization).WithMany(p => p.Students)
                .HasForeignKey(d => d.SpecilizationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Students_Specializations");
        }
    }
}
