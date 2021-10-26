using InterviewTool.Application.Commands;
using InterviewTool.Application.Models;
using InterviewTool.Domain.Repositories;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InterviewTool.Application.CommandHandlers
{
    public class TechnologyCommandHandler :
        IRequestHandler<CreateTechnologyCommand, ExecutionResult>,
        IRequestHandler<UpdateTechnologyCommand, ExecutionResult>,
        IRequestHandler<DeleteTechnologyCommand, ExecutionResult>
    {
        private readonly IUnitOfWork _uow;

        public TechnologyCommandHandler(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public Task<ExecutionResult> Handle(CreateTechnologyCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<ExecutionResult> Handle(UpdateTechnologyCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<ExecutionResult> Handle(DeleteTechnologyCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
