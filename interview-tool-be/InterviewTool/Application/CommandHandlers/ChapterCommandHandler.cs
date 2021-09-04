using InterviewTool.Application.Commands;
using InterviewTool.Application.Models;
using InterviewTool.Domain.Entities;
using InterviewTool.Domain.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace InterviewTool.Application.CommandHandlers
{
    public class ChapterCommandHandler :
        IRequestHandler<CreateChapterCommand, ExecutionResult>,
        IRequestHandler<UpdateChapterCommand, ExecutionResult>,
        IRequestHandler<DeleteChapterCommand, ExecutionResult>
    {
        private readonly IUnitOfWork _uow;

        public ChapterCommandHandler(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<ExecutionResult> Handle(CreateChapterCommand request, CancellationToken cancellationToken)
        {
            var chapterToInsert = new Chapter(request.Name, request.Weight);
            _uow.ChapterRepository.Insert(chapterToInsert);
            var result = await _uow.SaveAsync();

            return result > 0 ? ExecutionResult.FromSuccess() : ExecutionResult.FromFailure("Error saving chapter");
        }

        public async Task<ExecutionResult> Handle(UpdateChapterCommand request, CancellationToken cancellationToken)
        {
            var chapterToUpdate = await _uow.ChapterRepository.GetByIdAsync(request.ChapterId);
            chapterToUpdate.UpdateName(request.Name);
            chapterToUpdate.UpdateWeight(request.Weight);
            var result = await _uow.SaveAsync();

            return result > 0 ? ExecutionResult.FromSuccess() : ExecutionResult.FromFailure("Error updating chapter");
        }

        public async Task<ExecutionResult> Handle(DeleteChapterCommand request, CancellationToken cancellationToken)
        {
            await _uow.ChapterRepository.DeleteByIdAsync(request.ChapterId);
            var result = await _uow.SaveAsync();

            return result > 0 ? ExecutionResult.FromSuccess() : ExecutionResult.FromFailure("Error deleting chapter");
        }
    }
}
