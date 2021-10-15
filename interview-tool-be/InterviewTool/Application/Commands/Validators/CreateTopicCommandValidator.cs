using FluentValidation;

namespace InterviewTool.Application.Commands.Validators
{
    public class CreateTopicCommandValidator : AbstractValidator<CreateTopicCommand>
    {
        public CreateTopicCommandValidator()
        {
            RuleFor(x => x.ChapterId).GreaterThan(0);
            RuleFor(x => x.TechnologyId).GreaterThan(0);
            RuleFor(x => x.Name).NotNull().NotEmpty();
            RuleFor(x => x.Weight).GreaterThan(0);
        }
    }
}
