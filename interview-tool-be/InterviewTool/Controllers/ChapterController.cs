using InterviewTool.Application.Commands;
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
            return default;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetChapter(int id)
        {
            return default;
        }

        [HttpPost]
        public async Task<IActionResult> CreateChapter(CreateChapterCommand command)
        {
            var result = await _mediator.Send(command);
            var statusCode = result.Success ? StatusCodes.Status201Created : StatusCodes.Status400BadRequest;

            return StatusCode(statusCode, result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateChapter()
        {
            return default;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveChapter(int id)
        {
            return default;
        }
    }
}
