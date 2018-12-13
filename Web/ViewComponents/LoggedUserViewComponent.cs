﻿using Core.Entities;
using Core.Interfaces;
using Core.Services;
using Infrastructure.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Extensions;
using Web.ViewModels;

namespace Web.ViewComponents
{
    [ViewComponent]
    public class LoggedUserViewComponent : ViewComponent
    {
        private UserManager<ApplicationUser> _userManager;
        private IProjectService _projectService;
        //private IHttpContextAccessor _httpContext;

        public LoggedUserViewComponent(UserManager<ApplicationUser> userManager, IProjectService projectService)
        {
            _userManager = userManager;
            _projectService = projectService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Project project = null;
            int? selectedProjectId = HttpContext.Request.Cookies.GetProjectId();
            if(selectedProjectId != null)
            {
                project = await _projectService.Get(selectedProjectId);
            }

            var user = await _userManager.GetUserAsync(HttpContext.User);

            return View("Default", new LoggedUserViewModel()
            {
                User = user,
                Project = project
            });
        }
    }
}