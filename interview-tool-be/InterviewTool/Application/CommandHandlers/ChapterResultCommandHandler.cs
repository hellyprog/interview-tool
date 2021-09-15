using InterviewTool.Application.Commands;
using InterviewTool.Application.Models;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InterviewTool.Application.CommandHandlers
{
    public class ChapterResultCommandHandler :
        IRequestHandler<CreateChapterResultCommand, ExecutionResult>,
        IRequestHandler<UpdateChapterResultCommand, ExecutionResult>,
        IRequestHandler<DeleteChapterResultCommand, ExecutionResult>
    {
        public Task<ExecutionResult> Handle(CreateChapterResultCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<ExecutionResult> Handle(UpdateChapterResultCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<ExecutionResult> Handle(DeleteChapterResultCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
