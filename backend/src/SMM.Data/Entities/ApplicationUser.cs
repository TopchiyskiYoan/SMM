using Microsoft.AspNetCore.Identity;
using SMM.Data.Enums;

namespace SMM.Data.Entities;

/// <summary>
/// Application user. Username, Email and PasswordHash are provided by IdentityUser.
/// Roles are managed through ASP.NET Core Identity roles.
/// </summary>
public class ApplicationUser : IdentityUser<Guid>
{
    public AccountStatus AccountStatus { get; set; } = AccountStatus.Active;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public UserProfile? Profile { get; set; }

    public ICollection<Track> Tracks { get; set; } = new List<Track>();

    public ICollection<Post> Posts { get; set; } = new List<Post>();

    public ICollection<Group> OwnedGroups { get; set; } = new List<Group>();

    public ICollection<GroupMember> GroupMemberships { get; set; } = new List<GroupMember>();

    /// <summary>Users who follow this user.</summary>
    public ICollection<Follow> Followers { get; set; } = new List<Follow>();

    /// <summary>Users this user follows.</summary>
    public ICollection<Follow> Following { get; set; } = new List<Follow>();

    public ICollection<ConversationMember> ConversationMemberships { get; set; } = new List<ConversationMember>();

    public ICollection<Message> SentMessages { get; set; } = new List<Message>();
}
