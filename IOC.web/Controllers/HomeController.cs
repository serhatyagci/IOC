using IOC.web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IOC.web.Controllers
{
    public class HomeController : Controller
    {
        //nesne örneği alınıyor.
        private readonly ITransientDateService _transient;
        public HomeController(ITransientDateService transient)
        {
            _transient = transient;
        }

        //2. kez nesne örneği alıyoruz ardaki farkı görmek için.
        public IActionResult Index([FromServices]ITransientDateService transient2)
        {
            //iki nesneden de alınan ayrı timelar.
            ViewBag.time1 = _transient.GetDateTime.TimeOfDay.ToString();
            ViewBag.time2 = transient2.GetDateTime.TimeOfDay.ToString();
            return View();
        }

        public IActionResult Privacy()
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