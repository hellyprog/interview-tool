using FluentValidation;

namespace InterviewTool.Application.Commands.Validators
{
    public class UpdateTopicCommandValidator : AbstractValidator<UpdateTopicCommand>
    {
        public UpdateTopicCommandValidator()
        {
            RuleFor(x => x.TopicId).GreaterThan(0);
            RuleFor(x => x.Name).NotNull().NotEmpty();
            RuleFor(x => x.Weight).GreaterThan(0);
        }
    }
}
