using FluentValidation;

namespace CustomValidators;

public static class CustomValidators
{
    public static IRuleBuilderOptions<T, IActive> IsActive<T>(
        this IRuleBuilder<T, IActive> ruleBuilder)
    {
        return ruleBuilder.Must(item => item.Active).WithMessage("item was not active");
    }

    // public static StartsWithA<T>(
    // this IRuleBuilder<T, string?> ruleBuilder)
    // {
    //     return ruleBuilder.Must(item => item.StartsWith("a")).WithMessage("item was not active");
    // }
}