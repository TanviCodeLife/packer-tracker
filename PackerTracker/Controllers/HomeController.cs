using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;

namespace PackerTracker.Controllers
{
    public class HomeController : Controller
    {
        [Route("/index")]
        public ActionResult Index() { return View(); }

    }
}
