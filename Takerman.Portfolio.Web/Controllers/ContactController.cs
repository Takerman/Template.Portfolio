using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Takerman.Portfolio.Web.Models;
using Takerman.Portfolio.Web.Models.Filters;

namespace Takerman.Portfolio.Web.Controllers
{
    [CompanyActionFilter]
    public class ContactController : BaseController
    {
        public ContactController(ILogger<ContactController> logger) : base(logger)
        {
        }

        public IActionResult Index()
        {
            Layout.Banner.Title = "Contact";
            Layout.Banner.NavLinks = new List<NavLink>()
            {
                new NavLink(){ Action = "Index", Controller = "Home", Label = "Home" },
                new NavLink(){ Action = "Index", Controller = "Contact", Label = "Contact" },
            };
            return View();
        }
    }
}