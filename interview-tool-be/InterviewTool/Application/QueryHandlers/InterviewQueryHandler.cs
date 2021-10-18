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
    public class InterviewQueryHandler :
        IRequestHandler<GetInterviewQuery, ExecutionResult<InterviewDTO>>,
        IRequestHandler<GetInterviewsQuery, ExecutionResult<List<InterviewDTO>>>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public InterviewQueryHandler(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<ExecutionResult<InterviewDTO>> Handle(GetInterviewQuery request, CancellationToken cancellationToken)
        {
            var interview = await _uow.InterviewRepository.GetByIdAsync(request.InterviewId);

            return interview != null
                ? ExecutionResult<InterviewDTO>.FromSuccess(_mapper.Map<InterviewDTO>(interview))
                : ExecutionResult<InterviewDTO>.FromFailure("Error getting interview");
        }

        public async Task<ExecutionResult<List<InterviewDTO>>> Handle(GetInterviewsQuery request, CancellationToken cancellationToken)
        {
            var interviews = await _uow.InterviewRepository.GetAll()
                .Where(x => !request.IsFinished.HasValue || x.IsFinished == request.IsFinished)
                .ToListAsync(cancellationToken: cancellationToken);

            return ExecutionResult<List<InterviewDTO>>.FromSuccess(_mapper.Map<List<InterviewDTO>>(interviews));
        }
    }
}
