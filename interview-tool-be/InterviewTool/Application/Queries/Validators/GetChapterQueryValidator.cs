using FluentValidation;

namespace InterviewTool.Application.Queries.Validators
{
    public class GetChapterQueryValidator : AbstractValidator<GetChapterQuery>
    {
        public GetChapterQueryValidator()
        {
            RuleFor(x => x.ChapterId).GreaterThan(0);
        }
    }
}
