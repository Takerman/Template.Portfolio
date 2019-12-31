using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Takerman.Portfolio.Web.Models;
using Takerman.Portfolio.Web.Models.Filters;

namespace Takerman.Portfolio.Web.Controllers
{
    [CompanyActionFilter]
    public class AboutController : BaseController
    {
        public AboutController(ILogger<AboutController> logger) : base(logger)
        {
        }

        public IActionResult Index()
        {
            Layout.Banner.Title = "About";
            Layout.Banner.NavLinks = new List<NavLink>()
            {
                new NavLink(){ Action = "Index", Controller = "Home", Label = "Home" },
                new NavLink(){ Action = "Index", Controller = "About", Label = "About" },
            };
            return View();
        }
    }
}