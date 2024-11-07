using FluentValidation;

namespace CustomValidators;

public class TestValidator : AbstractValidator<DomainItem>
{
    public TestValidator()
    {
        RuleFor(x => x).IsActive();
    }
}