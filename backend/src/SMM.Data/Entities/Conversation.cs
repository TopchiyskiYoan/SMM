using SMM.Data.Enums;

namespace SMM.Data.Entities;

public class Conversation
{
    public Guid Id { get; set; }

    public ConversationType ConversationType { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public ICollection<ConversationMember> Members { get; set; } = new List<ConversationMember>();

    public ICollection<Message> Messages { get; set; } = new List<Message>();
}
