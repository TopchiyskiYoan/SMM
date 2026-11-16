using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMM.Data.Entities;
using Limits = SMM.Data.Constants.DataConstants;

namespace SMM.Data.Configurations;

public class TrackConfiguration : IEntityTypeConfiguration<Track>
{
    public void Configure(EntityTypeBuilder<Track> builder)
    {
        builder.Property(t => t.Title).IsRequired().HasMaxLength(Limits.Track.TitleMaxLength);
        builder.Property(t => t.Description).HasMaxLength(Limits.Track.DescriptionMaxLength);
        builder.Property(t => t.AudioUrl).IsRequired().HasMaxLength(Limits.UrlMaxLength);
        builder.Property(t => t.CoverImageUrl).HasMaxLength(Limits.UrlMaxLength);

        builder.HasOne(t => t.User)
            .WithMany(u => u.Tracks)
            .HasForeignKey(t => t.UserId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
