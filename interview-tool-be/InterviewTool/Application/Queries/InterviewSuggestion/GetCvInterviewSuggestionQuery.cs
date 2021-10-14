using InterviewTool.Application.Models;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace InterviewTool.Application.Queries.InterviewSuggestion
{
    public class GetCvInterviewSuggestionQuery : IRequest<ExecutionResult<string>>
    {
        public IFormFile File { get; set; }
    }
}
