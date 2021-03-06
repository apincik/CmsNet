﻿using Blognet.Cms.Core.PageForwards.Commands.CreatePageForward;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using Blognet.Cms.Domain.Enum;

namespace Blognet.Cms.Core.PageForwards.Validators
{
    public class CreatePageForwardValidator : AbstractValidator<CreatePageForwardCommand>
    {
        public CreatePageForwardValidator()
        {
            RuleFor(x => x.SourceId)
                .NotEmpty()
                .When(x => x.Type == PageForwardSourceType.Article)
                .WithMessage("SourceId for Article PageForward must be set.");
        }
    }
}
