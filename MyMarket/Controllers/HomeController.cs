using Microsoft.AspNetCore.Mvc;
using MyMarket.Models;
using MyMarket.Resources;
using System.Diagnostics;

namespace MyMarket.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.PageTitle = Resource.Index_Page_Title;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
