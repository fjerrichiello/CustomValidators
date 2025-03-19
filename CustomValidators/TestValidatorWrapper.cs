using FluentValidation;

namespace CustomValidators;

public class TestValidatorWrapper : AbstractValidator<ValidatorWrapper>
{
    public TestValidatorWrapper()
    {
        RuleFor(x => x.DomainItem)
            .Must(IsEffective)
            .IsActive();
    }

    private bool IsEffective(ValidatorWrapper parameters, DomainItem domainItem)
    {
        return domainItem.Date <= parameters.SecondDomainItem.Date;
    }

    protect bool IsEffective(ValidatorWrapper wrapper)

    protected bool StartsWithA(string input)
    {
        return input.StartsWith("a");
    }
}