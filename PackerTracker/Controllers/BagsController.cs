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
      // return View(allBags);
      return new EmptyResult();
    }
  }
}
