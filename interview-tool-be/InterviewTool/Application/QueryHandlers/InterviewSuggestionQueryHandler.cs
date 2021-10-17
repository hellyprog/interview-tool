using InterviewTool.Application.Models;
using InterviewTool.Application.Queries.InterviewSuggestion;
using InterviewTool.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace InterviewTool.Application.QueryHandlers
{
    public class InterviewSuggestionQueryHandler :
        IRequestHandler<GetCvInterviewSuggestionQuery, ExecutionResult<string>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public InterviewSuggestionQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ExecutionResult<string>> Handle(GetCvInterviewSuggestionQuery request, CancellationToken cancellationToken)
        {
            using var reader = new StreamReader(request.File.OpenReadStream());
            var fileContent = await reader.ReadToEndAsync();

            var technologies = await _unitOfWork.TechnologyRepository.GetAll().ToListAsync();
            var technologyScore = new Dictionary<string, int>();

            foreach (var item in technologies)
            {
                if (fileContent.Contains(item.Name))
                {
                    var technologyCount = fileContent.Split(' ').Count(x => x == item.Name);
                    technologyScore.Add(item.Name, 1);
                }
            }

            return ExecutionResult<string>.FromSuccess(technologyScore.OrderByDescending(x => x.Value).First().Key);
        }
    }
}
