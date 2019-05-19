﻿using Blognet.Cms.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blognet.Cms.Core.Articles.Commands.ToggleArticleStatus
{
    public class ToggleArticleStatusCommand : IRequest
    {
        public int Id;
    }
}
