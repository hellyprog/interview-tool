using InterviewTool.Application.Queries.InterviewSuggestion;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace InterviewTool.Controllers
{
    [Route("api/interview-suggestions")]
    [ApiController]
    public class InterviewSuggestionController : BaseApplicationController
    {
        private readonly IMediator _mediator;

        public InterviewSuggestionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("cv")]
        public async Task<IActionResult> GetInterviewSuggestion([FromQuery] GetCvInterviewSuggestionQuery query)
        {
            var result = await _mediator.Send(query);
            var statusCode = result.Success ? StatusCodes.Status200OK : StatusCodes.Status400BadRequest;

            return StatusCode(statusCode, result);
        }
    }
}
