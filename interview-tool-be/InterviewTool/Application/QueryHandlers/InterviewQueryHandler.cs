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
    public class InterviewQueryHandler :
        IRequestHandler<GetInterviewQuery, ExecutionResult<InterviewDTO>>,
        IRequestHandler<GetInterviewsQuery, ExecutionResult<List<InterviewDTO>>>
    {
        public Task<ExecutionResult<InterviewDTO>> Handle(GetInterviewQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<ExecutionResult<List<InterviewDTO>>> Handle(GetInterviewsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
