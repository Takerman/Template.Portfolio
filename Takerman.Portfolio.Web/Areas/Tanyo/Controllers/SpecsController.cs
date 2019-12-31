using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Takerman.Portfolio.Web.Models;

namespace Takerman.Portfolio.Web.Areas.Tanyo.Controllers
{
    public class SpecsController : BaseController
    {
        public SpecsController(ILogger<BaseController> logger) : base(logger)
        {
        }

        public IActionResult Index()
        {
            Layout.Banner.Title = "Specs";
            Layout.Banner.NavLinks = new List<NavLink>()
            {
                new NavLink(){ Action = "Index", Controller = "Home", Label = "Home" },
                new NavLink(){ Action = "Index", Controller = "Specs", Label = "Specs" },
            };
            return View();
        }
    }
}