using InterviewTool.Application.DTOs;
using InterviewTool.Application.Models;
using MediatR;

namespace InterviewTool.Application.Queries
{
    public class GetTopicResultQuery : IRequest<ExecutionResult<TopicResultDTO>>
    {
        public int TopicResultId { get; set; }
    }
}
