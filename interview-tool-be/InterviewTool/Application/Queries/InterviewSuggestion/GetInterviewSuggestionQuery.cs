using InterviewTool.Application.Models;
using MediatR;

namespace InterviewTool.Application.Queries.InterviewSuggestion
{
    public class GetInterviewSuggestionQuery : IRequest<ExecutionResult<string>>
    {
        public string LinkedInUrl { get; set; }
    }
}
