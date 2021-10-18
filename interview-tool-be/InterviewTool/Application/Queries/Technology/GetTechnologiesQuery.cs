using InterviewTool.Application.DTOs;
using InterviewTool.Application.Models;
using MediatR;
using System.Collections.Generic;

namespace InterviewTool.Application.Queries.Technology
{
    public class GetTechnologiesQuery : IRequest<ExecutionResult<List<TechnologyDTO>>>
    {
    }
}
