using FluentValidation;

namespace InterviewTool.Application.Commands.Validators
{
    public class CreateChapterCommandValidator : AbstractValidator<CreateChapterCommand>
    {
        public CreateChapterCommandValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty();
            RuleFor(x => x.Weight).GreaterThan(0);
        }
    }
}
