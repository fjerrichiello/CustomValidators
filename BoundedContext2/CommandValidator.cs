using Common;
using FluentValidation;

namespace BoundedContext2;

public class CommandValidator : AbstractValidator<CommandData2>
{
    public CommandValidator()
    {
        RuleFor(x => x)
            .Must(ValidatorRules.MemberActive);
    }
}