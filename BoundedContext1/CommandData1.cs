using Common;

namespace BoundedContext1;

public record CommandData1(int Id, Member? Member) : IMemberCommandData<Member>;