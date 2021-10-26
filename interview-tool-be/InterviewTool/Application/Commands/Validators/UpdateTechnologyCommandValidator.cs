using FluentValidation;

namespace InterviewTool.Application.Commands.Validators
{
    public class UpdateTechnologyCommandValidator : AbstractValidator<UpdateTechnologyCommand>
    {
        public UpdateTechnologyCommandValidator()
        {
            RuleFor(x => x.TechnologyId).GreaterThan(0);
            RuleFor(x => x.Name).NotNull().NotEmpty();
        }
    }
}
