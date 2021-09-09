using InterviewTool.Application.DTOs;
using InterviewTool.Application.Models;
using MediatR;

namespace InterviewTool.Application.Queries
{
    public class GetTopicQuery : IRequest<ExecutionResult<ChapterDTO>>
    {
    }
}
