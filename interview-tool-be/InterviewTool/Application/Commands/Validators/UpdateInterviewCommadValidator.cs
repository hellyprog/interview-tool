using FluentValidation;

namespace InterviewTool.Application.Commands.Validators
{
    public class UpdateInterviewCommadValidator : AbstractValidator<UpdateInterviewCommand>
    {
        public UpdateInterviewCommadValidator()
        {
            RuleFor(x => x.InterviewId).GreaterThan(0);
            RuleFor(x => x.CandidateName).NotNull().NotEmpty();
        }
    }
}
