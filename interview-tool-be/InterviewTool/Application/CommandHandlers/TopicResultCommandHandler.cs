using InterviewTool.Application.Commands;
using InterviewTool.Application.Models;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InterviewTool.Application.CommandHandlers
{
    public class TopicResultCommandHandler :
        IRequestHandler<CreateTopicResultCommand, ExecutionResult>,
        IRequestHandler<UpdateTopicResultCommand, ExecutionResult>,
        IRequestHandler<DeleteTopicResultCommand, ExecutionResult>
    {
        public Task<ExecutionResult> Handle(CreateTopicResultCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<ExecutionResult> Handle(UpdateTopicResultCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<ExecutionResult> Handle(DeleteTopicResultCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
