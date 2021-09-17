using AutoMapper;
using InterviewTool.Application.DTOs;
using InterviewTool.Application.Models;
using InterviewTool.Application.Queries;
using InterviewTool.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace InterviewTool.Application.QueryHandlers
{
    public class ChapterResultQueryHandler :
        IRequestHandler<GetChapterResultsQuery, ExecutionResult<List<ChapterResultDTO>>>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public ChapterResultQueryHandler(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<ExecutionResult<List<ChapterResultDTO>>> Handle(GetChapterResultsQuery request, CancellationToken cancellationToken)
        {
            var chapterResults = await _uow.ChapterResultRepository.GetAll().Where(x => x.InterviewId == request.InterviewId).ToListAsync();

            return ExecutionResult<List<ChapterResultDTO>>.FromSuccess(_mapper.Map<List<ChapterResultDTO>>(chapterResults));
        }
    }
}
