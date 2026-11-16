namespace SMM.Data.Entities;

/// <summary>Follower follows Following. Composite key (FollowerId, FollowingId).</summary>
public class Follow
{
    public Guid FollowerId { get; set; }

    public ApplicationUser Follower { get; set; } = null!;

    public Guid FollowingId { get; set; }

    public ApplicationUser Following { get; set; } = null!;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
