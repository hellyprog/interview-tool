using InterviewTool.Application.Commands;
using InterviewTool.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace InterviewTool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChapterController : BaseApplicationController
    {
        private readonly IMediator _mediator;

        public ChapterController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetChapters()
        {
            var result = await _mediator.Send(new GetChaptersQuery());
            var statusCode = result.Success ? StatusCodes.Status200OK : StatusCodes.Status400BadRequest;

            return StatusCode(statusCode, result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetChapter(int chapterId)
        {
            var result = await _mediator.Send(new GetChapterQuery { ChapterId = chapterId });
            var statusCode = result.Success ? StatusCodes.Status200OK : StatusCodes.Status400BadRequest;

            return StatusCode(statusCode, result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateChapter([FromBody] CreateChapterCommand command)
        {
            var result = await _mediator.Send(command);
            var statusCode = result.Success ? StatusCodes.Status201Created : StatusCodes.Status400BadRequest;

            return StatusCode(statusCode, result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateChapter([FromBody] UpdateChapterCommand command)
        {
            var result = await _mediator.Send(command);
            var statusCode = result.Success ? StatusCodes.Status200OK : StatusCodes.Status400BadRequest;

            return StatusCode(statusCode, result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChapter(int chapterId)
        {
            var result = await _mediator.Send(new DeleteChapterCommand { ChapterId = chapterId });
            var statusCode = result.Success ? StatusCodes.Status200OK : StatusCodes.Status400BadRequest;

            return StatusCode(statusCode, result);
        }
    }
}
