using FluentValidation;

namespace InterviewTool.Application.Commands.Validators
{
    public class CreateTechnologyCommandValidator : AbstractValidator<CreateTechnologyCommand>
    {
        public CreateTechnologyCommandValidator()
        {
            RuleFor(x => x.TechnologyName).NotNull().NotEmpty();
        }
    }
}
