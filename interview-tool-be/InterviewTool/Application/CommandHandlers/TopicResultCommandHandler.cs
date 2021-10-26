using InterviewTool.Application.Commands;
using InterviewTool.Application.Models;
using InterviewTool.Domain.Entities;
using InterviewTool.Domain.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace InterviewTool.Application.CommandHandlers
{
    public class TopicResultCommandHandler :
        IRequestHandler<CreateTopicResultCommand, ExecutionResult>,
        IRequestHandler<UpdateTopicResultCommand, ExecutionResult>,
        IRequestHandler<DeleteTopicResultCommand, ExecutionResult>
    {
        private readonly IUnitOfWork _uow;

        public TopicResultCommandHandler(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<ExecutionResult> Handle(CreateTopicResultCommand request, CancellationToken cancellationToken)
        {
            var topicResultToInsert = new TopicResult(request.ChapterResultId, request.Point, request.TopicId);
            _uow.TopicResultRepository.Insert(topicResultToInsert);
            var result = await _uow.SaveAsync();

            return result > 0 ? ExecutionResult.FromSuccess() : ExecutionResult.FromFailure("Error saving topic result");
        }

        public async Task<ExecutionResult> Handle(UpdateTopicResultCommand request, CancellationToken cancellationToken)
        {
            var topicResultToUpdate = await _uow.TopicResultRepository.GetByIdAsync(request.TopicResultId);
            topicResultToUpdate.UpdatePoint(request.Point);
            var result = await _uow.SaveAsync();

            return result > 0 ? ExecutionResult.FromSuccess() : ExecutionResult.FromFailure("Error updating topic result");
        }

        public async Task<ExecutionResult> Handle(DeleteTopicResultCommand request, CancellationToken cancellationToken)
        {
            await _uow.TopicResultRepository.DeleteByIdAsync(request.TopicResultId);
            var result = await _uow.SaveAsync();

            return result > 0 ? ExecutionResult.FromSuccess() : ExecutionResult.FromFailure("Error deleting topic result");
        }
    }
}
