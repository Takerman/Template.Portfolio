using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using Takerman.Portfolio.Web.Models.Filters;

namespace Takerman.Portfolio.Web.Areas.Tanyo.Controllers
{
    [Area("Tanyo")]
    [Host("tanyo.takerman.net")]
    [ProfileActionFilter]
    public abstract class BaseController : Web.Controllers.BaseController
    {
        public BaseController(ILogger<BaseController> logger) : base(logger)
        {
        }
    }
}