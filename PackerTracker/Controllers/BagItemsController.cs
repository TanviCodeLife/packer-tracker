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
      // return new EmptyResult(); Fail CorrectView test
      //return View(0); Fail CorrectModelType Test
    }

    [HttpGet("/bag-items/new")]
    public ActionResult New()
    {
      return View();
      // return new EmptyResult(); Fail CorrectView test
    }

    [HttpPost("/bag-items")]
    public ActionResult Create(string nameOfItem, int price, int weight, bool packed)
    {
      BagItem newBagItem = new BagItem(nameOfItem, price, weight, packed);
      return RedirectToAction("Index");
      //return new EmptyResult(); Fail CorrectView test
    }

    [HttpGet("/bag-items/{id}")]
    public ActionResult Show(int id)
    {
      BagItem foundBagItem = BagItem.Find(id);
      return View(foundBagItem);
      //return View(0); Fail CorrectModelType Test
    }

    [HttpPost("/bag-items/delete")]
    public ActionResult Destroy()
    {
      BagItem.ClearAll();
      return View("Index");
      // return new EmptyResult(); Fail CorrectView test
    }
  }
}
