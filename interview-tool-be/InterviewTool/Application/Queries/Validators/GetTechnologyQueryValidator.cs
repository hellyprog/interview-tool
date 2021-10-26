﻿using FluentValidation;

namespace InterviewTool.Application.Queries.Validators
{
    public class GetTechnologyQueryValidator : AbstractValidator<GetTechnologyQuery>
    {
        public GetTechnologyQueryValidator()
        {
            RuleFor(x => x.TechnologyId).GreaterThan(0);
        }
    }
}
