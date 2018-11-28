using Microsoft.AspNetCore.Mvc;
using PackBag.Models;

namespace PackerTracker.Controllers
{
    public class HomeController : Controller
    {
        [Route("/index")]
        public ActionResult Index() { return View(); }

    }
}
