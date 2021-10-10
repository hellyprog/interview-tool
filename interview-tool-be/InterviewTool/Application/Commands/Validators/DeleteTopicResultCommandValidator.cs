using FluentValidation;

namespace InterviewTool.Application.Commands.Validators
{
    public class DeleteTopicResultCommandValidator : AbstractValidator<DeleteTopicResultCommand>
    {
        public DeleteTopicResultCommandValidator()
        {
            RuleFor(x => x.TopicResultId).GreaterThan(0);
        }
    }
}
