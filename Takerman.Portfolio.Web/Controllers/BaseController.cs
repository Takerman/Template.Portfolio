using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Takerman.Portfolio.Web.Models.Contracts;

namespace Takerman.Portfolio.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        public ILayout Layout { get; set; }

        protected ILogger<BaseController> _logger;

        public BaseController(ILogger<BaseController> logger)
        {
            ViewData["Layout"] = Layout;
            _logger = logger;
        }
    }
}