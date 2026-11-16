using SMM.Data.Enums;

namespace SMM.Data.Entities;

public class Group
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public GroupVisibility Visibility { get; set; } = GroupVisibility.Public;

    public Guid OwnerId { get; set; }

    public ApplicationUser Owner { get; set; } = null!;

    public string? CoverImageUrl { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public ICollection<GroupMember> Members { get; set; } = new List<GroupMember>();

    public ICollection<Post> Posts { get; set; } = new List<Post>();
}
