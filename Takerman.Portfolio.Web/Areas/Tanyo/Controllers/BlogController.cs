using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Takerman.Portfolio.Web.Models;

namespace Takerman.Portfolio.Web.Areas.Tanyo.Controllers
{
    public class BlogController : BaseController
    {
        public BlogController(ILogger<BaseController> logger) : base(logger)
        {
        }

        public IActionResult Index()
        {
            Layout.Banner.Title = "Blog";
            Layout.Banner.NavLinks = new List<NavLink>()
            {
                new NavLink(){ Action = "Index", Controller = "Home", Label = "Home" },
                new NavLink(){ Action = "Index", Controller = "Blog", Label = "Blog" },
            };
            return View();
        }
        public IActionResult Post(string name)
        {
            Layout.Banner.Title = "Blog";
            Layout.Banner.NavLinks = new List<NavLink>()
            {
                new NavLink(){ Action = "Index", Controller = "Home", Label = "Home" },
                new NavLink(){ Action = "Index", Controller = "Blog", Label = "Blog" },
                new NavLink(){ Action = "Post", Controller = "Blog", Label = name, Data = new { area = "Tanyo", name = name } },
            };
            return View("post-" + name);
        }
    }
}