using InterviewTool.Application.Commands;
using InterviewTool.Application.Models;
using InterviewTool.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace InterviewTool.Application.CommandHandlers
{
    public class ChapterCommandHandler :
        IRequestHandler<CreateChapterCommand, ExecutionResult>
    {
        private readonly IUnitOfWork _uow;

        public ChapterCommandHandler(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<ExecutionResult> Handle(CreateChapterCommand request, CancellationToken cancellationToken)
        {
            _uow.ChapterRepository.Insert(new Domain.Entities.Chapter { Name = request.Name, Weight = request.Weight });
            var result = await _uow.SaveAsync();

            return result > 0 ? ExecutionResult.FromSuccess() : ExecutionResult.FromFailure("Error saving chapter");
        }
    }
}
