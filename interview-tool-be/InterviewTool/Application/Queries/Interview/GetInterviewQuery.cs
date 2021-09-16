using InterviewTool.Application.DTOs;
using InterviewTool.Application.Models;
using MediatR;

namespace InterviewTool.Application.Queries
{
    public class GetInterviewQuery : IRequest<ExecutionResult<InterviewDTO>>
    {
        public int InterviewId { get; set; }
    }
}
