using SMM.Data.Enums;

namespace SMM.Data.Entities;

/// <summary>A post: text, audio or video. Optionally belongs to a group and/or references a track.</summary>
public class Post
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public ApplicationUser User { get; set; } = null!;

    public Guid? GroupId { get; set; }

    public Group? Group { get; set; }

    public Guid? TrackId { get; set; }

    public Track? Track { get; set; }

    public PostType PostType { get; set; }

    public string? Content { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
