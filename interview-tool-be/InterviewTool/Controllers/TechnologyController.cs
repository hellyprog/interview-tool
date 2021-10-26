using InterviewTool.Application.Commands;
using InterviewTool.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace InterviewTool.Controllers
{
    [Route("api/technologies")]
    [ApiController]
    public class TechnologyController : BaseApplicationController
    {
        private readonly IMediator _mediator;

        public TechnologyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetTechnologies()
        {
            var result = await _mediator.Send(new GetTechnologiesQuery());
            var statusCode = result.Success ? StatusCodes.Status200OK : StatusCodes.Status400BadRequest;

            return StatusCode(statusCode, result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTechnology(int technologyId)
        {
            var result = await _mediator.Send(new GetTechnologyQuery { TechnologyId = technologyId });
            var statusCode = result.Success ? StatusCodes.Status200OK : StatusCodes.Status400BadRequest;

            return StatusCode(statusCode, result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTechnology([FromBody] CreateTechnologyCommand command)
        {
            var result = await _mediator.Send(command);
            var statusCode = result.Success ? StatusCodes.Status201Created : StatusCodes.Status400BadRequest;

            return StatusCode(statusCode, result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTechnology([FromBody] UpdateTechnologyCommand command)
        {
            var result = await _mediator.Send(command);
            var statusCode = result.Success ? StatusCodes.Status200OK : StatusCodes.Status400BadRequest;

            return StatusCode(statusCode, result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTechnology(int technolodyId)
        {
            var result = await _mediator.Send(new DeleteTechnologyCommand { TechnologyId = technolodyId });
            var statusCode = result.Success ? StatusCodes.Status200OK : StatusCodes.Status400BadRequest;

            return StatusCode(statusCode, result);
        }
    }
}
