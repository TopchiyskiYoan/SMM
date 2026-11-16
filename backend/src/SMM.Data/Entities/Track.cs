namespace SMM.Data.Entities;

/// <summary>An uploaded audio recording.</summary>
public class Track
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public ApplicationUser User { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public string AudioUrl { get; set; } = null!;

    public string? CoverImageUrl { get; set; }

    public bool IsDemo { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public ICollection<Post> Posts { get; set; } = new List<Post>();
}
