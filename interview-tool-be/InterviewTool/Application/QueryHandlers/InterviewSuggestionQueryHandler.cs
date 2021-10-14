using InterviewTool.Application.Models;
using InterviewTool.Application.Queries.InterviewSuggestion;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace InterviewTool.Application.QueryHandlers
{
    public class InterviewSuggestionQueryHandler :
        IRequestHandler<GetCvInterviewSuggestionQuery, ExecutionResult<string>>
    {

        public InterviewSuggestionQueryHandler()
        {
        }

        public async Task<ExecutionResult<string>> Handle(GetCvInterviewSuggestionQuery request, CancellationToken cancellationToken)
        {
            return default;
        }
    }
}
