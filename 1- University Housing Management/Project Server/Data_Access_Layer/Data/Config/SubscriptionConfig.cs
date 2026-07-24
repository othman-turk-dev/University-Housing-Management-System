using Data_Access_Layer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data_Access_Layer.Data.Config
{
    public class SubscriptionConfig : IEntityTypeConfiguration<Subscription>
    {
        public void Configure(EntityTypeBuilder<Subscription> builder)
        {
            builder.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");
            builder.Property(e => e.SubscriptionTypeId).HasColumnName("SubscriptionTypeID");

            builder.HasOne(d => d.SubscriptionType).WithMany(p => p.Subscriptions)
                .HasForeignKey(d => d.SubscriptionTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Subscriptions_SubscriptionTypes");
        }
    }
}
