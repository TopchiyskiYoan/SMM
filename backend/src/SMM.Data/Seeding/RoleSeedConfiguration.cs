using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMM.Data.Constants;

namespace SMM.Data.Seeding;

/// <summary>
/// Seeds the application roles. Ids and concurrency stamps are fixed
/// so migrations stay deterministic.
/// </summary>
public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole<Guid>>
{
    public void Configure(EntityTypeBuilder<IdentityRole<Guid>> builder)
    {
        builder.HasData(
            CreateRole("8c1f5a3e-2b7d-4e6a-9f10-3a5b7c9d1e01", RoleNames.Musician),
            CreateRole("8c1f5a3e-2b7d-4e6a-9f10-3a5b7c9d1e02", RoleNames.Producer),
            CreateRole("8c1f5a3e-2b7d-4e6a-9f10-3a5b7c9d1e03", RoleNames.Studio),
            CreateRole("8c1f5a3e-2b7d-4e6a-9f10-3a5b7c9d1e04", RoleNames.Administrator));
    }

    private static IdentityRole<Guid> CreateRole(string id, string name) => new()
    {
        Id = Guid.Parse(id),
        Name = name,
        NormalizedName = name.ToUpperInvariant(),
        ConcurrencyStamp = id,
    };
}
