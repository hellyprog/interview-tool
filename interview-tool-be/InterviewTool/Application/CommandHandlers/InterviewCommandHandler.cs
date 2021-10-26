using InterviewTool.Application.Commands;
using InterviewTool.Application.Models;
using InterviewTool.Domain.Entities;
using InterviewTool.Domain.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace InterviewTool.Application.CommandHandlers
{
    public class InterviewCommandHandler :
        IRequestHandler<CreateInterviewCommand, ExecutionResult>,
        IRequestHandler<UpdateInterviewCommand, ExecutionResult>,
        IRequestHandler<DeleteInterviewCommand, ExecutionResult>
    {
        private readonly IUnitOfWork _uow;

        public InterviewCommandHandler(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public async Task<ExecutionResult> Handle(CreateInterviewCommand request, CancellationToken cancellationToken)
        {
            var interviewToInsert = new Interview(request.CandidateName);
            _uow.InterviewRepository.Insert(interviewToInsert);
            var result = await _uow.SaveAsync();

            return result > 0 ? ExecutionResult.FromSuccess() : ExecutionResult.FromFailure("Error saving interview");
        }

        public async Task<ExecutionResult> Handle(UpdateInterviewCommand request, CancellationToken cancellationToken)
        {
            var interviewToUpdate = await _uow.InterviewRepository.GetByIdAsync(request.InterviewId);
            interviewToUpdate.UpdateCandidateName(request.CandidateName);
            var result = await _uow.SaveAsync();

            return result > 0 ? ExecutionResult.FromSuccess() : ExecutionResult.FromFailure("Error updating interview");
        }

        public async Task<ExecutionResult> Handle(DeleteInterviewCommand request, CancellationToken cancellationToken)
        {
            await _uow.InterviewRepository.DeleteByIdAsync(request.InterviewId);
            var result = await _uow.SaveAsync();

            return result > 0 ? ExecutionResult.FromSuccess() : ExecutionResult.FromFailure("Error deleting interview");
        }
    }
}
