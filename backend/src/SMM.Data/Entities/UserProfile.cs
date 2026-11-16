using SMM.Data.Enums;

namespace SMM.Data.Entities;

public class UserProfile
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public ApplicationUser User { get; set; } = null!;

    public string DisplayName { get; set; } = null!;

    public string? Biography { get; set; }

    public string? ProfilePictureUrl { get; set; }

    public string? Country { get; set; }

    public string? City { get; set; }

    public VerificationStatus VerificationStatus { get; set; } = VerificationStatus.Unverified;
}
