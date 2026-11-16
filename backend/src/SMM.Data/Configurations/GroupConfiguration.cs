using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMM.Data.Entities;
using Limits = SMM.Data.Constants.DataConstants;

namespace SMM.Data.Configurations;

public class GroupConfiguration : IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.Property(g => g.Name).IsRequired().HasMaxLength(Limits.Group.NameMaxLength);
        builder.Property(g => g.Description).HasMaxLength(Limits.Group.DescriptionMaxLength);
        builder.Property(g => g.CoverImageUrl).HasMaxLength(Limits.UrlMaxLength);

        builder.HasOne(g => g.Owner)
            .WithMany(u => u.OwnedGroups)
            .HasForeignKey(g => g.OwnerId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
