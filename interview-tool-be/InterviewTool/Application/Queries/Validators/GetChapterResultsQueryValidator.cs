using FluentValidation;

namespace InterviewTool.Application.Queries.Validators
{
    public class GetChapterResultsQueryValidator : AbstractValidator<GetChapterResultsQuery>
    {
        public GetChapterResultsQueryValidator()
        {
            RuleFor(x => x.InterviewId).GreaterThan(0);
        }
    }
}
