using InterviewTool.Application.DTOs;
using InterviewTool.Application.Models;
using MediatR;

namespace InterviewTool.Application.Queries
{
    public class GetChapterResultQuery : IRequest<ExecutionResult<ChapterResultDTO>>
    {
        public int ChapterResultId { get; set; }
    }
}
