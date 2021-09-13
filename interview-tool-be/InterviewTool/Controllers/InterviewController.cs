using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
