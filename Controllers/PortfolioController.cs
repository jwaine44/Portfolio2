using Microsoft.AspNetCore.Mvc;
// change the namespace name to name of your project!
namespace Porfolio2.Controllers;
    public class PortfolioController : Controller
    {
        // for each route this controller is to handle:
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("projects")]
        public IActionResult Projects()
        {
            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View();
        }

    }