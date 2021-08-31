﻿using InterviewTool.Application.DTOs;
using InterviewTool.Application.Models;
using InterviewTool.Application.Queries;
using InterviewTool.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace InterviewTool.Application.QueryHandlers
{
    public class ChapterQueryHandler : 
        IRequestHandler<GetChapterQuery, ExecutionResult<ChapterDTO>>,
        IRequestHandler<GetChaptersQuery, ExecutionResult<List<ChapterDTO>>>

    {
        private readonly IUnitOfWork _uow;

        public ChapterQueryHandler(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<ExecutionResult<ChapterDTO>> Handle(GetChapterQuery request, CancellationToken cancellationToken)
        {
            var chapter = await _uow.ChapterRepository.GetById(request.ChapterId);

            return chapter != null
                ? ExecutionResult<ChapterDTO>.FromSuccess(new ChapterDTO()) // Automapper
                : ExecutionResult<ChapterDTO>.FromFailure("Error getting chapter");
        }

        public async Task<ExecutionResult<List<ChapterDTO>>> Handle(GetChaptersQuery request, CancellationToken cancellationToken)
        {
            var chapters = await _uow.ChapterRepository.GetAll().ToListAsync();

            return ExecutionResult<List<ChapterDTO>>.FromSuccess(new List<ChapterDTO>()); //automapper
        }
    }
}
