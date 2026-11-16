namespace SMM.Data.Entities;

/// <summary>
/// Participant in a conversation. Composite key (ConversationId, UserId).
/// LastReadAt tracks read state per participant, so unread messages are
/// those with SentAt later than LastReadAt.
/// </summary>
public class ConversationMember
{
    public Guid ConversationId { get; set; }

    public Conversation Conversation { get; set; } = null!;

    public Guid UserId { get; set; }

    public ApplicationUser User { get; set; } = null!;

    public DateTime JoinedAt { get; set; } = DateTime.UtcNow;

    public DateTime? LastReadAt { get; set; }
}
