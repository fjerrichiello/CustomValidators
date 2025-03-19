namespace CustomValidators;

public record DomainItem(bool Active, string? Test, DateOnly Date) : IActive;