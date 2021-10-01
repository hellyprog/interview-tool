using FluentValidation;

namespace InterviewTool.Application.Commands.Validators
{
    public class CreateInterviewCommandValidator : AbstractValidator<CreateInterviewCommand>
    {
        public CreateInterviewCommandValidator()
        {
            RuleFor(x => x.CandidateName).NotNull().NotEmpty();
        }
    }
}
