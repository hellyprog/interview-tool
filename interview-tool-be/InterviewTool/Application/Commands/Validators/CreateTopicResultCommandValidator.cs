using FluentValidation;

namespace InterviewTool.Application.Commands.Validators
{
    public class CreateTopicResultCommandValidator : AbstractValidator<CreateTopicResultCommand>
    {
        public CreateTopicResultCommandValidator()
        {
            RuleFor(x => x.ChapterResultId).GreaterThan(0);
            RuleFor(x => x.Point).GreaterThanOrEqualTo(0);
            RuleFor(x => x.TopicId).GreaterThan(0);
        }
    }
}
