using InterviewTool.Application.DTOs;
using InterviewTool.Application.Models;
using MediatR;
using System.Collections.Generic;

namespace InterviewTool.Application.Queries
{
    public class GetChapterResultsQuery : IRequest<ExecutionResult<List<ChapterResultDTO>>>
    {
        public int InterviewId { get; set; }
    }
}
