using AutoMapper;
using InterviewTool.Application.DTOs;
using InterviewTool.Application.Models;
using InterviewTool.Application.Queries;
using InterviewTool.Domain.Repositories;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace InterviewTool.Application.QueryHandlers
{
    public class TopicQueryHandler :
        IRequestHandler<GetTopicQuery, ExecutionResult<TopicDTO>>,
        IRequestHandler<GetTopicsQuery, ExecutionResult<List<TopicDTO>>>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public TopicQueryHandler(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public Task<ExecutionResult<TopicDTO>> Handle(GetTopicQuery request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<ExecutionResult<List<TopicDTO>>> Handle(GetTopicsQuery request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
