using FluentValidation;

namespace InterviewTool.Application.Commands.Validators
{
    public class DeleteTechnologyCommandValidator : AbstractValidator<DeleteTechnologyCommand>
    {
        public DeleteTechnologyCommandValidator()
        {
            RuleFor(x => x.TechnologyId).GreaterThan(0);
        }
    }
}
