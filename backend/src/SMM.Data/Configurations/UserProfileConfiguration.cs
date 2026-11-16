using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMM.Data.Entities;
using Limits = SMM.Data.Constants.DataConstants;

namespace SMM.Data.Configurations;

public class UserProfileConfiguration : IEntityTypeConfiguration<UserProfile>
{
    public void Configure(EntityTypeBuilder<UserProfile> builder)
    {
        builder.Property(p => p.DisplayName).IsRequired().HasMaxLength(Limits.UserProfile.DisplayNameMaxLength);
        builder.Property(p => p.Biography).HasMaxLength(Limits.UserProfile.BiographyMaxLength);
        builder.Property(p => p.ProfilePictureUrl).HasMaxLength(Limits.UrlMaxLength);
        builder.Property(p => p.Country).HasMaxLength(Limits.UserProfile.CountryMaxLength);
        builder.Property(p => p.City).HasMaxLength(Limits.UserProfile.CityMaxLength);

        // One profile per user; deleting the user deletes the profile.
        builder.HasOne(p => p.User)
            .WithOne(u => u.Profile)
            .HasForeignKey<UserProfile>(p => p.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(p => p.UserId).IsUnique();
    }
}
