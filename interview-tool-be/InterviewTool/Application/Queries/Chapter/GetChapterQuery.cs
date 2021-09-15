using InterviewTool.Application.DTOs;
using InterviewTool.Application.Models;
using MediatR;

namespace InterviewTool.Application.Queries
{
    public class GetChapterQuery : IRequest<ExecutionResult<ChapterDTO>>
    {
        public int ChapterId { get; set; }
    }
}
