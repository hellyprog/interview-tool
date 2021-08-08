using InterviewTool.Application.Commands;
using InterviewTool.Application.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace InterviewTool.Application.CommandHandlers
{
    public class ChapterCommandHandler :
        IRequestHandler<CreateChapterCommand, ExecutionResult>
    {
        public Task<ExecutionResult> Handle(CreateChapterCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
