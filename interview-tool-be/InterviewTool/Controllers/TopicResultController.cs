using InterviewTool.Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace InterviewTool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicResultController : BaseApplicationController
    {
        private readonly IMediator _mediator;

        public TopicResultController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateTopicResult([FromBody] CreateTopicResultCommand command)
        {
            var result = await _mediator.Send(command);
            var statusCode = result.Success ? StatusCodes.Status201Created : StatusCodes.Status400BadRequest;

            return StatusCode(statusCode, result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTopicResult([FromBody] UpdateTopicResultCommand command)
        {
            var result = await _mediator.Send(command);
            var statusCode = result.Success ? StatusCodes.Status200OK : StatusCodes.Status400BadRequest;

            return StatusCode(statusCode, result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTopicResult(int topicResultId)
        {
            var result = await _mediator.Send(new DeleteTopicResultCommand { TopicResultId = topicResultId });
            var statusCode = result.Success ? StatusCodes.Status200OK : StatusCodes.Status400BadRequest;

            return StatusCode(statusCode, result);
        }
    }
}
