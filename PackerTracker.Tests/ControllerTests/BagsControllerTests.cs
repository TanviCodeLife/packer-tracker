using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using PackerTracker.Controllers;
using PackerTracker.Models;
using System;

namespace PackerTracker.Tests
{
  [TestClass]
  public class BagsControllerTest
  {

    [TestMethod]
    public void Index_ReturnsCorrectView_True()
    {
      //Arrange
      BagsController controller = new BagsController();

      //Act
      ActionResult indexView = controller.Index();

      //Assert
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }

    [TestMethod]
    public void Index_HasCorrectModelType_BagItemList()
    {
      //Arrange
      BagsController controller = new BagsController();
      ViewResult indexView = controller.Index() as ViewResult;

      //Act
      var result = indexView.ViewData.Model;

      //Assert
      Assert.IsInstanceOfType(result, typeof(List<Bag>));
    }

    [TestMethod]
    public void New_ReturnsCorrectView_True()
    {
      //Arrange
      BagsController controller = new BagsController();

      //Act
      ActionResult newView = controller.Index();

      //Assert
      Assert.IsInstanceOfType(newView, typeof(ViewResult));
    }

    [TestMethod]
    public void Create_ReturnsCorrectActionType_True()
    {
      //Arrange
      BagsController controller = new BagsController();

      //Act
      ActionResult indexView = controller.Create("Clutch");

      //Assert
      Assert.IsInstanceOfType(indexView, typeof(RedirectToActionResult));
    }

    [TestMethod]
    public void Create_ReturnsCorrectActionName_True()
    {
      //Arrange
      BagsController controller = new BagsController();
      RedirectToActionResult indexView = controller.Create("Clutch") as RedirectToActionResult;

      //Act
      var result = indexView.ActionName;
      //Assert
      Assert.AreEqual(result, "Index");
    }

    [TestMethod]
    public void Show_ReturnsCorrectView_True()
    {
      //Arrange
      BagsController controller = new BagsController();
      Bag testBag = new Bag("Purse");
      BagItem testBagItem = new BagItem("camera", 1, 2, true);
      testBag.AddBagItem(testBagItem);
      Console.WriteLine(testBag.GetId());

      //Act
      ActionResult showView = controller.Show(testBag.GetId());

      //Assert
      Assert.IsInstanceOfType(showView, typeof(ViewResult));
    }

    [TestMethod]
    public void Show_HasCorrectModelType_Dictionary()
    {
      //Arrange
      BagsController controller = new BagsController();
      Bag testBag = new Bag("Purse");
      BagItem testBagItem = new BagItem("camera", 1, 2, true);
      testBag.AddBagItem(testBagItem);
      Console.WriteLine(testBag.GetId());
      ViewResult showView = controller.Show(testBag.GetId()) as ViewResult;

      //Act
      var result = showView.ViewData.Model;
      Console.WriteLine(result.GetType());
      Console.WriteLine(typeof(Dictionary<string, object>));
      //Assert
      Assert.AreEqual(result.GetType(), typeof(Dictionary<string, object>));
    }

  }
}
