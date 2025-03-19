using Common;

namespace BoundedContext2;

public record CommandData2(int Id, Member? Member) : IMemberCommandData<Member>;