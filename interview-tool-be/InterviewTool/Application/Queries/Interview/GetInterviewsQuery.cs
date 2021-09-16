using InterviewTool.Application.DTOs;
using InterviewTool.Application.Models;
using MediatR;
using System.Collections.Generic;

namespace InterviewTool.Application.Queries
{
    public class GetInterviewsQuery : IRequest<ExecutionResult<List<InterviewDTO>>>
    {
    }
}
