using FluentValidation;

namespace CustomValidators;

public class TestValidator : AbstractValidator<DomainItem>
{
    public TestValidator()
    {
        RuleFor(x => x).IsActive();

        RuleFor(x => x.Test)
            .NotEmpty();

        When(x => !string.IsNullOrWhiteSpace(x.Test), () =>
        {
            RuleFor(x => x.Test)
                .Must(StartsWithA);
        });
    }

    protected bool StartsWithA(string input)
    {
        return input.StartsWith("a");
    }
}