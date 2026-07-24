using Data_Access_Layer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data_Access_Layer.Data.Config
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(e => e.UserId).HasColumnName("UserID");
            builder.Property(e => e.Username).HasMaxLength(50);
            builder.Property(e => e.RefreshTokenExpiresAt).HasColumnType("datetime");
            builder.Property(e => e.RefreshTokenRevokedAt).HasColumnType("datetime");
        }
    }
}
