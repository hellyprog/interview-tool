using FluentValidation;

namespace InterviewTool.Application.Commands.Validators
{
    public class DeleteChapterCommandValidator : AbstractValidator<DeleteChapterCommand>
    {
        public DeleteChapterCommandValidator()
        {
            RuleFor(x => x.ChapterId).GreaterThan(0);
        }
    }
}
