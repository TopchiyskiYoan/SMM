using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SMM.Data.Entities;

namespace SMM.Data;

public class SmmDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
{
    public SmmDbContext(DbContextOptions<SmmDbContext> options)
        : base(options)
    {
    }

    public DbSet<UserProfile> UserProfiles => Set<UserProfile>();

    public DbSet<Track> Tracks => Set<Track>();

    public DbSet<Post> Posts => Set<Post>();

    public DbSet<Group> Groups => Set<Group>();

    public DbSet<GroupMember> GroupMembers => Set<GroupMember>();

    public DbSet<Follow> Follows => Set<Follow>();

    public DbSet<Conversation> Conversations => Set<Conversation>();

    public DbSet<ConversationMember> ConversationMembers => Set<ConversationMember>();

    public DbSet<Message> Messages => Set<Message>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(typeof(SmmDbContext).Assembly);
    }
}
