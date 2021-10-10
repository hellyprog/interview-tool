using FluentValidation;

namespace InterviewTool.Application.Commands.Validators
{
    public class UpdateTopicResultCommandValidator : AbstractValidator<UpdateTopicResultCommand>
    {
        public UpdateTopicResultCommandValidator()
        {
            RuleFor(x => x.TopicResultId).GreaterThan(0);
            RuleFor(x => x.Point).GreaterThanOrEqualTo(0);
        }
    }
}
