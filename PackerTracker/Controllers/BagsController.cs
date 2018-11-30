using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;

namespace PackerTracker.Controllers
{
  public class BagsController : Controller
  {
    [HttpGet("/bags")]
    public ActionResult Index()
    {
      List<Bag> allBags = Bag.GetAll();
      return View(allBags);
      // return new EmptyResult();
      //return View(0); Fail CorrectModelType Test
    }

    [HttpGet("/bags/new")]
    public ActionResult New()
    {
      return View();
      // return new EmptyResult(); Fail CorrectView test
    }

    [HttpPost("/bags")]
    public ActionResult Create(string bagName)
    {
      Bag newBag = new Bag(bagName);
      return RedirectToAction("Index");
      //return new EmptyResult();
      //return RedirectToAction("null");
    }

    [HttpGet("/bags/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Bag selectedBag = Bag.Find(id);
      List<BagItem> bagItems = selectedBag.GetBagItems();

      model.Add("bag", selectedBag);
      model.Add("items", bagItems);
      return View(model);
      
      // return new EmptyResult(); Fails Correct View test
      //return View(0); //Fail CorrectModelType Test
    }




  }
}
