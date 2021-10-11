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
    public class ChapterResultCommandHandler :
        IRequestHandler<CreateChapterResultCommand, ExecutionResult>,
        IRequestHandler<UpdateChapterResultCommand, ExecutionResult>,
        IRequestHandler<DeleteChapterResultCommand, ExecutionResult>
    {
        private readonly IUnitOfWork _uow;

        public ChapterResultCommandHandler(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<ExecutionResult> Handle(CreateChapterResultCommand request, CancellationToken cancellationToken)
        {
            var chapterResultToInsert = new ChapterResult(request.InterviewId, request.Point, request.ChapterId);
            _uow.ChapterResultRepository.Insert(chapterResultToInsert);
            var result = await _uow.SaveAsync();

            return result > 0 ? ExecutionResult.FromSuccess() : ExecutionResult.FromFailure("Error saving chapter result");
        }

        public async Task<ExecutionResult> Handle(UpdateChapterResultCommand request, CancellationToken cancellationToken)
        {
            var chapterResultToUpdate = await _uow.ChapterResultRepository.GetByIdAsync(request.ChapterResultId);
            chapterResultToUpdate.UpdatePoint(request.Point);
            var result = await _uow.SaveAsync();

            return result > 0 ? ExecutionResult.FromSuccess() : ExecutionResult.FromFailure("Error updating chapter result");
        }

        public async Task<ExecutionResult> Handle(DeleteChapterResultCommand request, CancellationToken cancellationToken)
        {
            await _uow.ChapterResultRepository.DeleteByIdAsync(request.ChapterResultId);
            var result = await _uow.SaveAsync();

            return result > 0 ? ExecutionResult.FromSuccess() : ExecutionResult.FromFailure("Error deleting chapter result");
        }
    }
}
