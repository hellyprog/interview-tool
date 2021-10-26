using AutoMapper;
using InterviewTool.Application.DTOs;
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
    public class TechnologyQueryHandler :
        IRequestHandler<GetTechnologyQuery, ExecutionResult<TechnologyDTO>>,
        IRequestHandler<GetTechnologiesQuery, ExecutionResult<List<TechnologyDTO>>>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public TechnologyQueryHandler(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<ExecutionResult<TechnologyDTO>> Handle(GetTechnologyQuery request, CancellationToken cancellationToken)
        {
            var technology = await _uow.TechnologyRepository.GetByIdAsync(request.TechnologyId);

            return technology != null
                ? ExecutionResult<TechnologyDTO>.FromSuccess(_mapper.Map<TechnologyDTO>(technology))
                : ExecutionResult<TechnologyDTO>.FromFailure("Error getting technology");
        }

        public async Task<ExecutionResult<List<TechnologyDTO>>> Handle(GetTechnologiesQuery request, CancellationToken cancellationToken)
        {
            var technologies = await _uow.TechnologyRepository.GetAll()
                .ToListAsync(cancellationToken: cancellationToken);

            return ExecutionResult<List<TechnologyDTO>>.FromSuccess(_mapper.Map<List<TechnologyDTO>>(technologies));
        }
    }
}
