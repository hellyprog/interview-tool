using InterviewTool.Application.Commands;
using InterviewTool.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace InterviewTool.Controllers
{
    [Route("api/interviews")]
    [ApiController]
    public class InterviewController : BaseApplicationController
    {
        private readonly IMediator _mediator;

        public InterviewController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetInterviews()
        {
            var result = await _mediator.Send(new GetInterviewsQuery());
            var statusCode = result.Success ? StatusCodes.Status200OK : StatusCodes.Status400BadRequest;

            return StatusCode(statusCode, result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetInterview(int interviewId)
        {
            var result = await _mediator.Send(new GetInterviewQuery { InterviewId = interviewId });
            var statusCode = result.Success ? StatusCodes.Status200OK : StatusCodes.Status400BadRequest;

            return StatusCode(statusCode, result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateInterview([FromBody] CreateInterviewCommand command)
        {
            var result = await _mediator.Send(command);
            var statusCode = result.Success ? StatusCodes.Status201Created : StatusCodes.Status400BadRequest;

            return StatusCode(statusCode, result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateInterview([FromBody] UpdateInterviewCommand command)
        {
            var result = await _mediator.Send(command);
            var statusCode = result.Success ? StatusCodes.Status200OK : StatusCodes.Status400BadRequest;

            return StatusCode(statusCode, result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInterview(int interviewId)
        {
            var result = await _mediator.Send(new DeleteInterviewCommand { InterviewId = interviewId });
            var statusCode = result.Success ? StatusCodes.Status200OK : StatusCodes.Status400BadRequest;

            return StatusCode(statusCode, result);
        }

        [HttpPost("cv-suggestion")]
        public async Task<IActionResult> GetInterviewSuggestion([FromForm] GetCvInterviewSuggestionQuery query)
        {
            var result = await _mediator.Send(query);
            var statusCode = result.Success ? StatusCodes.Status200OK : StatusCodes.Status400BadRequest;

            return StatusCode(statusCode, result);
        }

        [HttpGet("technology/{technology}")]
        public async Task<IActionResult> GetInterviewQuestionsByTechnology(string technology)
        {
            return default;
        }
    }
}
