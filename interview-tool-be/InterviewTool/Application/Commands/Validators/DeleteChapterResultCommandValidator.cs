using FluentValidation;

namespace InterviewTool.Application.Commands.Validators
{
    public class DeleteChapterResultCommandValidator : AbstractValidator<DeleteChapterResultCommand>
    {
        public DeleteChapterResultCommandValidator()
        {
            RuleFor(x => x.ChapterResultId).GreaterThan(0);
        }
    }
}
