using Data_Access_Layer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data_Access_Layer.Data.Config
{
    public class ViolationConfig : IEntityTypeConfiguration<Violation>
    {
        public void Configure(EntityTypeBuilder<Violation> builder)
        {
            builder.Property(e => e.ViolationId).HasColumnName("ViolationID");
            builder.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            builder.Property(e => e.Date).HasColumnType("datetime");
            builder.Property(e => e.Fine).HasColumnType("smallmoney");
            builder.Property(e => e.StudentId)
                .HasMaxLength(50)
                .HasColumnName("StudentID");
            builder.Property(e => e.ViolationTypeId).HasColumnName("ViolationTypeID");

            builder.HasOne(d => d.CreatedByUser).WithMany(p => p.Violations)
                .HasForeignKey(d => d.CreatedByUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Violations_Users");

            builder.HasOne(d => d.Student).WithMany(p => p.Violations)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_Violations_Students");

            builder.HasOne(d => d.ViolationType).WithMany(p => p.Violations)
                .HasForeignKey(d => d.ViolationTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Violations_ViolationTypes");
        }
    }
}
