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
    public class TopicResultQueryHandler :
        IRequestHandler<GetTopicResultQuery, ExecutionResult<TopicResultDTO>>,
        IRequestHandler<GetTopicResultsQuery, ExecutionResult<List<TopicResultDTO>>>
    {
        public Task<ExecutionResult<TopicResultDTO>> Handle(GetTopicResultQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<ExecutionResult<List<TopicResultDTO>>> Handle(GetTopicResultsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
