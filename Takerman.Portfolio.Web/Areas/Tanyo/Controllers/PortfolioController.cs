﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Takerman.Portfolio.Web.Models;
using Takerman.Portfolio.Web.Models.Partials;

namespace Takerman.Portfolio.Web.Areas.Tanyo.Controllers
{
    public class PortfolioController : BaseController
    {
        public PortfolioController(ILogger<BaseController> logger) : base(logger)
        {
        }

        public IActionResult Index()
        {
            Layout.Banner.Title = "Portfolio";
            Layout.Banner.NavLinks = new List<NavLink>()
            {
                new NavLink(){ Action = "Index", Controller = "Home", Label = "Home" },
                new NavLink(){ Action = "Index", Controller = "Portfolio", Label = "Portfolio" },
            };

            var model = new Models.Partials.Portfolio(AreaType.Profile);
            return View(model);
        }

        public IActionResult Project(string name)
        {
            Layout.Banner.Title = "Portfolio";
            Layout.Banner.NavLinks = new List<NavLink>()
            {
                new NavLink(){ Action = "Index", Controller = "Home", Label = "Home" },
                new NavLink(){ Action = "Index", Controller = "Portfolio", Label = "Portfolio" },
                new NavLink(){ Action = "Project", Controller = "Portfolio", Data = new { name = name }, Label = name },
            };
            return View(name);
        }
    }
}