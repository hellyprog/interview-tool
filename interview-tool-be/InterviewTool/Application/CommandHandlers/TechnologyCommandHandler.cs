using InterviewTool.Application.Commands;
using InterviewTool.Application.Models;
using InterviewTool.Domain.Entities;
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

        public async Task<ExecutionResult> Handle(CreateTechnologyCommand request, CancellationToken cancellationToken)
        {
            var technologyToInsert = new Technology(request.Name);
            _uow.TechnologyRepository.Insert(technologyToInsert);
            var result = await _uow.SaveAsync();

            return result > 0 ? ExecutionResult.FromSuccess() : ExecutionResult.FromFailure("Error saving technology");
        }

        public async Task<ExecutionResult> Handle(UpdateTechnologyCommand request, CancellationToken cancellationToken)
        {
            var technologyToUpdate = await _uow.TechnologyRepository.GetByIdAsync(request.TechnologyId);
            technologyToUpdate.UpdateName(request.Name);
            var result = await _uow.SaveAsync();

            return result > 0 ? ExecutionResult.FromSuccess() : ExecutionResult.FromFailure("Error updating technology");
        }

        public async Task<ExecutionResult> Handle(DeleteTechnologyCommand request, CancellationToken cancellationToken)
        {
            await _uow.TechnologyRepository.DeleteByIdAsync(request.TechnologyId);
            var result = await _uow.SaveAsync();

            return result > 0 ? ExecutionResult.FromSuccess() : ExecutionResult.FromFailure("Error deleting technology");
        }
    }
}
