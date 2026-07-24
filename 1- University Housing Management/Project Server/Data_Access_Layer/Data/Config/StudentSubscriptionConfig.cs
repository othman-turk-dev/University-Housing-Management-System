using Data_Access_Layer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data_Access_Layer.Data.Config
{
    public class StudentSubscriptionConfig : IEntityTypeConfiguration<StudentSubscription>
    {
        public void Configure(EntityTypeBuilder<StudentSubscription> builder)
        {
            builder.Property(e => e.StudentSubscriptionId).HasColumnName("StudentSubscriptionID");
            builder.Property(e => e.EndDate).HasColumnType("datetime");
            builder.Property(e => e.StartDate).HasColumnType("datetime");
            builder.Property(e => e.StudentId)
        .HasMaxLength(50)
        .HasColumnName("StudentID");
            builder.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");

            builder.HasOne(d => d.Student).WithMany(p => p.StudentSubscriptions)
        .HasForeignKey(d => d.StudentId)
        .HasConstraintName("FK_StudentSubscriptions_Students");

            builder.HasOne(d => d.Subscription).WithMany(p => p.StudentSubscriptions)
        .HasForeignKey(d => d.SubscriptionId)
        .OnDelete(DeleteBehavior.ClientSetNull)
        .HasConstraintName("FK_StudentSubscriptions_Subscriptions");
        }
    }
}
