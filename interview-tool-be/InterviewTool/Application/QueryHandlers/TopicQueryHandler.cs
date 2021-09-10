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

        public async Task<ExecutionResult<TopicDTO>> Handle(GetTopicQuery request, CancellationToken cancellationToken)
        {
            var topic = await _uow.TopicRepository.GetByIdAsync(request.TopicId);

            return topic != null
                ? ExecutionResult<TopicDTO>.FromSuccess(_mapper.Map<TopicDTO>(topic))
                : ExecutionResult<TopicDTO>.FromFailure("Error getting topic");
        }

        public async Task<ExecutionResult<List<TopicDTO>>> Handle(GetTopicsQuery request, CancellationToken cancellationToken)
        {
            var topics = await _uow.TopicRepository.GetAll().ToListAsync();

            return ExecutionResult<List<TopicDTO>>.FromSuccess(_mapper.Map<List<TopicDTO>>(topics));
        }
    }
}
