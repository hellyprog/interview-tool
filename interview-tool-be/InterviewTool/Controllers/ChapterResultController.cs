using InterviewTool.Application.Commands;
using InterviewTool.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace InterviewTool.Controllers
{
    public class ChapterResultController : BaseApplicationController
    {
        private readonly IMediator _mediator;

        public ChapterResultController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetChapterResults()
        {
            var result = await _mediator.Send(new GetChapterResultsQuery());
            var statusCode = result.Success ? StatusCodes.Status200OK : StatusCodes.Status400BadRequest;

            return StatusCode(statusCode, result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateChapterResult([FromBody] CreateChapterResultCommand command)
        {
            var result = await _mediator.Send(command);
            var statusCode = result.Success ? StatusCodes.Status201Created : StatusCodes.Status400BadRequest;

            return StatusCode(statusCode, result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateChapterResult([FromBody] UpdateChapterResultCommand command)
        {
            var result = await _mediator.Send(command);
            var statusCode = result.Success ? StatusCodes.Status200OK : StatusCodes.Status400BadRequest;

            return StatusCode(statusCode, result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChapterResult(int chapterResultId)
        {
            var result = await _mediator.Send(new DeleteChapterResultCommand { ChapterResultId = chapterResultId });
            var statusCode = result.Success ? StatusCodes.Status200OK : StatusCodes.Status400BadRequest;

            return StatusCode(statusCode, result);
        }
    }
}
