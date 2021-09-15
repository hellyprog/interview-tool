﻿using InterviewTool.Application.Models;
using MediatR;

namespace InterviewTool.Application.Commands
{
    public class DeleteChapterResultCommand : IRequest<ExecutionResult>
    {
    }
}