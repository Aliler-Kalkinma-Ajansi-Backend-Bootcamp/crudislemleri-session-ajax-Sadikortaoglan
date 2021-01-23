using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using data.Services;

namespace BlogSite.Controllers

{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult Index()
        {
            //MenuServices servis = new MenuServices();
            //servis.GetAllMenu();
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }


       
    }
}
