namespace SMM.Data.Entities;

public class Message
{
    public Guid Id { get; set; }

    public Guid ConversationId { get; set; }

    public Conversation Conversation { get; set; } = null!;

    public Guid SenderId { get; set; }

    public ApplicationUser Sender { get; set; } = null!;

    public string Content { get; set; } = null!;

    public DateTime SentAt { get; set; } = DateTime.UtcNow;
}
