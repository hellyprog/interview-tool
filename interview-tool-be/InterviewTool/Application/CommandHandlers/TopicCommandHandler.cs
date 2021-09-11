using InterviewTool.Application.Commands;
using InterviewTool.Application.Models;
using InterviewTool.Domain.Entities;
using InterviewTool.Domain.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace InterviewTool.Application.CommandHandlers
{
    public class TopicCommandHandler :
        IRequestHandler<CreateTopicCommand, ExecutionResult>,
        IRequestHandler<UpdateTopicCommand, ExecutionResult>,
        IRequestHandler<DeleteTopicCommand, ExecutionResult>
    {
        private readonly IUnitOfWork _uow;

        public TopicCommandHandler(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<ExecutionResult> Handle(CreateTopicCommand request, CancellationToken cancellationToken)
        {
            var topicToInsert = new Topic(request.Name, request.Weight);
            _uow.TopicRepository.Insert(topicToInsert);
            var result = await _uow.SaveAsync();

            return result > 0 ? ExecutionResult.FromSuccess() : ExecutionResult.FromFailure("Error saving topic");
        }

        public async Task<ExecutionResult> Handle(UpdateTopicCommand request, CancellationToken cancellationToken)
        {
            var topicToUpdate = await _uow.TopicRepository.GetByIdAsync(request.TopicId);
            topicToUpdate.UpdateName(request.Name);
            topicToUpdate.UpdateWeight(request.Weight);
            var result = await _uow.SaveAsync();

            return result > 0 ? ExecutionResult.FromSuccess() : ExecutionResult.FromFailure("Error updating topic");
        }

        public async Task<ExecutionResult> Handle(DeleteTopicCommand request, CancellationToken cancellationToken)
        {
            await _uow.TopicRepository.DeleteByIdAsync(request.TopicId);
            var result = await _uow.SaveAsync();

            return result > 0 ? ExecutionResult.FromSuccess() : ExecutionResult.FromFailure("Error deleting topic");
        }
    }
}
