using FluentValidation;

namespace InterviewTool.Application.Commands.Validators
{
    public class UpdateChapterCommandValidator : AbstractValidator<UpdateChapterCommand>
    {
        public UpdateChapterCommandValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty();
            RuleFor(x => x.Weight).GreaterThan(0);
        }
    }
}
