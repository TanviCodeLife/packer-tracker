using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;
using System.Collections.Generic;

namespace PackerTracker.Controllers
{
  public class BagItemsController : Controller
  {
    [HttpGet("/bag-items")]
    public ActionResult Index()
    {
      List<BagItem> allBagItem = BagItem.GetAll();
      return View(allBagItem);
    }

    [HttpGet("/bag-items/new")]
    public ActionResult New()
    {

      return View();
    }

  }
}
