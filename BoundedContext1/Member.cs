using Common;

namespace BoundedContext1;

public record Member(bool IsActive) : IMemberLike;