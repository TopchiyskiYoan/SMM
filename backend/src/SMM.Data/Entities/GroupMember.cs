using SMM.Data.Enums;

namespace SMM.Data.Entities;

public class GroupMember
{
    public Guid Id { get; set; }

    public Guid GroupId { get; set; }

    public Group Group { get; set; } = null!;

    public Guid UserId { get; set; }

    public ApplicationUser User { get; set; } = null!;

    public GroupMemberRole Role { get; set; } = GroupMemberRole.Member;

    public DateTime JoinedAt { get; set; } = DateTime.UtcNow;
}
