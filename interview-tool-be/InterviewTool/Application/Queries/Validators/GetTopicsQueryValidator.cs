using FluentValidation;

namespace InterviewTool.Application.Queries.Validators
{
    public class GetTopicsQueryValidator : AbstractValidator<GetTopicsQuery>
    {
        public GetTopicsQueryValidator()
        {
            RuleFor(x => x.ChapterId).GreaterThan(0);
        }
    }
}
