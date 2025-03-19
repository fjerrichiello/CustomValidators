namespace Common;

public interface IMemberCommandData<out TMember>
    where TMember : IMemberLike
{
    TMember? Member { get; }
}