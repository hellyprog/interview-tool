using FluentValidation;

namespace InterviewTool.Application.Commands.Validators
{
    public class UpdateChapterResultCommandValidator : AbstractValidator<UpdateChapterResultCommand>
    {
        public UpdateChapterResultCommandValidator()
        {
            RuleFor(x => x.ChapterResultId).GreaterThan(0);
            RuleFor(x => x.Point).GreaterThanOrEqualTo(0);
        }
    }
}
