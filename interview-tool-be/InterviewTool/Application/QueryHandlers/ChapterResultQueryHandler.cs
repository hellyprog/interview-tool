using InterviewTool.Application.DTOs;
using InterviewTool.Application.Models;
using InterviewTool.Application.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace InterviewTool.Application.QueryHandlers
{
    public class ChapterResultQueryHandler :
        IRequestHandler<GetChapterResultQuery, ExecutionResult<ChapterResultDTO>>,
        IRequestHandler<GetChapterResultsQuery, ExecutionResult<List<ChapterResultDTO>>>
    {
        public Task<ExecutionResult<ChapterResultDTO>> Handle(GetChapterResultQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<ExecutionResult<List<ChapterResultDTO>>> Handle(GetChapterResultsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
