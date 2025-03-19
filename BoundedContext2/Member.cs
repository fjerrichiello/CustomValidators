using Common;

namespace BoundedContext2;

public record Member(bool IsActive) : IMemberLike;