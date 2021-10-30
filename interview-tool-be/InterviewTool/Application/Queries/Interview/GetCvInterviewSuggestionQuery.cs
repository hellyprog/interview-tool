using InterviewTool.Application.DTOs;
using InterviewTool.Application.Models;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace InterviewTool.Application.Queries
{
    public class GetCvInterviewSuggestionQuery : IRequest<ExecutionResult<TechnologyDTO>>
    {
        public IFormFile File { get; set; }
    }
}
