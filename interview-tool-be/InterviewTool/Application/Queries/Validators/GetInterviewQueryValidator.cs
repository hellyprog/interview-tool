using FluentValidation;

namespace InterviewTool.Application.Queries.Validators
{
    public class GetInterviewQueryValidator : AbstractValidator<GetInterviewQuery>
    {
        public GetInterviewQueryValidator()
        {
            RuleFor(x => x.InterviewId).GreaterThan(0);
        }
    }
}
