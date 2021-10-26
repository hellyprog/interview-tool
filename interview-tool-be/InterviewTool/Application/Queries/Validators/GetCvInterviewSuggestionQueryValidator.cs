using FluentValidation;

namespace InterviewTool.Application.Queries.Validators
{
    public class GetCvInterviewSuggestionQueryValidator : AbstractValidator<GetCvInterviewSuggestionQuery>
    {
        public GetCvInterviewSuggestionQueryValidator()
        {
            CascadeMode = CascadeMode.Stop;

            RuleFor(x => x.File).NotNull();
            RuleFor(x => x.File.Length).GreaterThan(0);
        }
    }
}
