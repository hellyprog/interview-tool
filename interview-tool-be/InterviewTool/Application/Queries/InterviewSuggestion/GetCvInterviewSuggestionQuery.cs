﻿using InterviewTool.Application.Models;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace InterviewTool.Application.Queries
{
    public class GetCvInterviewSuggestionQuery : IRequest<ExecutionResult<string>>
    {
        public IFormFile File { get; set; }
    }
}
