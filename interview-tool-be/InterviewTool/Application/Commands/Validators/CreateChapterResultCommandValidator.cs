using FluentValidation;

namespace InterviewTool.Application.Commands.Validators
{
    public class CreateChapterResultCommandValidator : AbstractValidator<CreateChapterResultCommand>
    {
        public CreateChapterResultCommandValidator()
        {
            RuleFor(x => x.ChapterId).GreaterThan(0);
            RuleFor(x => x.InterviewId).GreaterThan(0);
            RuleFor(x => x.Point).GreaterThanOrEqualTo(0);
        }
    }
}
