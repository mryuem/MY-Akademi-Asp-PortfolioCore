using Microsoft.AspNetCore.Mvc;

namespace PortfolioCore.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult page404(int code)
        {
            Response.StatusCode = 404;
            return View();
        }
    }
}
