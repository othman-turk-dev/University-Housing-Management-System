using Data_Access_Layer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data_Access_Layer.Data.Config
{
    public class SubscriptionTypeConfig : IEntityTypeConfiguration<SubscriptionType>
    {
        public void Configure(EntityTypeBuilder<SubscriptionType> builder)
        {
            builder.Property(e => e.SubscriptionTypeId).HasColumnName("SubscriptionTypeID");
            builder.Property(e => e.Price).HasColumnType("smallmoney");
        }
    }
}
