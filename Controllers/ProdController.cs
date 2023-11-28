using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Req231123_V1.Models;

namespace Req231123_V1.Controllers
{
    public class ProdController : Controller
    {
        private readonly ILogger<ProdController> _logger;

        public ProdController(ILogger<ProdController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}