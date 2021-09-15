using InterviewTool.Application.Commands;
using InterviewTool.Application.Models;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InterviewTool.Application.CommandHandlers
{
    public class InterviewCommandHandler :
        IRequestHandler<CreateInterviewCommand, ExecutionResult>,
        IRequestHandler<UpdateInterviewCommand, ExecutionResult>,
        IRequestHandler<DeleteInterviewCommand, ExecutionResult>
    {
        public Task<ExecutionResult> Handle(CreateInterviewCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<ExecutionResult> Handle(UpdateInterviewCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<ExecutionResult> Handle(DeleteInterviewCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
