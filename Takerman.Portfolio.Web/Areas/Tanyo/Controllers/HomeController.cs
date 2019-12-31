using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Takerman.Portfolio.Web.Areas.Tanyo.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(ILogger<BaseController> logger) : base(logger)
        {
        }

        public IActionResult Index()
        {
            Layout.Banner = null;
            return View();
        }
    }
}