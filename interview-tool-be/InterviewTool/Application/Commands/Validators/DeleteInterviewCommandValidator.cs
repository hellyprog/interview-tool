using FluentValidation;

namespace InterviewTool.Application.Commands.Validators
{
    public class DeleteInterviewCommandValidator : AbstractValidator<DeleteInterviewCommand>
    {
        public DeleteInterviewCommandValidator()
        {
            RuleFor(x => x.InterviewId).GreaterThan(0);
        }
    }
}
