using MediatR;

namespace InterviewTool.Controllers
{
    public class InterviewController : BaseApplicationController
    {
        private readonly IMediator _mediator;

        public InterviewController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
