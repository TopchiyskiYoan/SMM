using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMM.Data.Entities;
using Limits = SMM.Data.Constants.DataConstants;

namespace SMM.Data.Configurations;

public class PostConfiguration : IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.Property(p => p.Content).HasMaxLength(Limits.Post.ContentMaxLength);

        builder.HasOne(p => p.User)
            .WithMany(u => u.Posts)
            .HasForeignKey(p => p.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(p => p.Group)
            .WithMany(g => g.Posts)
            .HasForeignKey(p => p.GroupId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(p => p.Track)
            .WithMany(t => t.Posts)
            .HasForeignKey(p => p.TrackId)
            .OnDelete(DeleteBehavior.Restrict);

        // Feed queries: newest posts first.
        builder.HasIndex(p => p.CreatedAt);
    }
}
