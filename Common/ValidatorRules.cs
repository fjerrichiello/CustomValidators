namespace Common;

public static class ValidatorRules
{
    public static bool MemberActive(IMemberCommandData<IMemberLike> commandData)
    {
        return commandData.Member?.IsActive ?? false;
    }
}