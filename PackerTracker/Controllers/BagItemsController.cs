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

    [HttpGet("/bags/{bagId}/bag-items/new")]
    public ActionResult New(int bagId)
    {
      Bag bag = Bag.Find(bagId);
      return View(bag);
      // return new EmptyResult(); Fail CorrectView test
    }

    [HttpPost("/bag-items")]
    public ActionResult Create(string nameOfItem, int price, int weight, bool packed)
    {
      BagItem newBagItem = new BagItem(nameOfItem, price, weight, packed);
      return RedirectToAction("Index");
      //return new EmptyResult(); Fail CorrectActionType test
      //return RedirectToAction("null"); Fail RedirectsToCorrectAction test
    }

    [HttpGet("/bags/{bagId}/bag-items/{bagItemId}")]
    public ActionResult Show(int bagId, int bagItemId)
    {
      BagItem foundBagItem = BagItem.Find(bagItemIdid);
      Bag foundBag = Bag.Find(bagId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("bag", foundBag);
      model.Add("item", foundBagItem);
      return View(foundBagItem);
      // return new EmptyResult(); Fails Correct View test
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
