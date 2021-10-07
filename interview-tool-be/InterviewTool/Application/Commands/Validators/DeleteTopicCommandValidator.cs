using FluentValidation;

namespace InterviewTool.Application.Commands.Validators
{
    public class DeleteTopicCommandValidator : AbstractValidator<DeleteTopicCommand>
    {
        public DeleteTopicCommandValidator()
        {
            RuleFor(x => x.TopicId).GreaterThan(0);
        }
    }
}
