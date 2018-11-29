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

    [HttpPost("/bag-items")]
    public ActionResult Create(string nameOfItem, int price, int weight, bool packed)
    {
      BagItem newBagItem = new BagItem(nameOfItem, price, weight, packed);
      return RedirectToAction("Index");
    }

    [HttpGet("/bag-items/{id}")]
    public ActionResult Show(int id)
    {
      BagItem foundBagItem = BagItem.Find(id);
      return View(0);
    }
  }
}
