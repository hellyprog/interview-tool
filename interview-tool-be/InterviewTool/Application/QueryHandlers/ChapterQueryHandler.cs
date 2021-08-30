using InterviewTool.Application.DTOs;
using InterviewTool.Application.Models;
using InterviewTool.Application.Queries;
using InterviewTool.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace InterviewTool.Application.QueryHandlers
{
    public class ChapterQueryHandler
        : IRequestHandler<GetChapterQuery, ExecutionResult<ChapterDTO>>
    {
        private readonly IUnitOfWork _uow;

        public ChapterQueryHandler(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public Task<ExecutionResult<ChapterDTO>> Handle(GetChapterQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
