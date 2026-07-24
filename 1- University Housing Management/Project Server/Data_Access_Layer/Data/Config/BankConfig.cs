using Data_Access_Layer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data_Access_Layer.Data.Config
{
    public class BankConfig : IEntityTypeConfiguration<Bank>
    {
        public void Configure(EntityTypeBuilder<Bank> builder)
        {
            builder.ToTable("Bank");

            builder.Property(e => e.BankId).HasColumnName("BankID");
            builder.Property(e => e.Amount).HasColumnType("smallmoney");
            builder.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            builder.Property(e => e.Date).HasColumnType("datetime");
            builder.Property(e => e.OperationType).HasMaxLength(250);
            builder.Property(e => e.StudentId)
                .HasMaxLength(50)
                .HasColumnName("StudentID");

            builder.HasOne(d => d.CreatedByUser).WithMany(p => p.Banks)
                .HasForeignKey(d => d.CreatedByUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Bank_Users");
        }
    }
}