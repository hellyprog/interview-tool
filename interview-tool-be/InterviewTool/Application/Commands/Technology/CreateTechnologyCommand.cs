using InterviewTool.Application.Models;
using MediatR;

namespace InterviewTool.Application.Commands
{
    public class CreateTechnologyCommand : IRequest<ExecutionResult>
    {
        public string Name { get; set; }
    }
}
