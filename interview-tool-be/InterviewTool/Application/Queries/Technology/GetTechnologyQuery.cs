using InterviewTool.Application.DTOs;
using InterviewTool.Application.Models;
using MediatR;

namespace InterviewTool.Application.Queries.Technology
{
    public class GetTechnologyQuery : IRequest<ExecutionResult<TechnologyDTO>>
    {
        public int TechnologyId { get; set; }
    }
}
