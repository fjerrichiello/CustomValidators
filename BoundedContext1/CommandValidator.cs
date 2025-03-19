using Common;
using FluentValidation;

namespace BoundedContext1;

public class CommandValidator : AbstractValidator<CommandData1>
{
    public CommandValidator()
    {
        RuleFor(x => x)
            .Must(ValidatorRules.MemberActive);
    }
}