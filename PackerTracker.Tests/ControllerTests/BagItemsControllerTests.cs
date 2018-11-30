using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PackerTracker.Controllers;
using PackerTracker.Models;
using System;

namespace PackerTracker.Tests
{
  [TestClass]
  public class BagItemsControllerTest
  {

    [TestMethod]
    public void Index_ReturnsCorrectView_True()
    {
      //Arrange
      BagItemsController controller = new BagItemsController();

      //Act
      ActionResult indexView = controller.Index();

      //Assert
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }

    [TestMethod]
    public void Index_HasCorrectModelType_BagItemList()
    {
      //Arrange
      BagItemsController controller = new BagItemsController();
      ViewResult indexView = controller.Index() as ViewResult;

      //Act
      var result = indexView.ViewData.Model;

      //Assert
      Assert.IsInstanceOfType(result, typeof(List<BagItem>));
    }

    [TestMethod]
    public void New_ReturnsCorrectView_True()
    {
      //Arrange
      BagItemsController controller = new BagItemsController();

      //Act
      ActionResult newView = controller.New();

      //Assert
      Assert.IsInstanceOfType(newView, typeof(ViewResult));
    }

    [TestMethod]
    public void Create_ReturnsCorrectActionType_True()
    {
      //Arrange
      BagItemsController controller = new BagItemsController();

      //Act
      string nameOfItem = "camera";
      int price = 1000;
      int weight = 5;
      bool packed = true;
      ActionResult indexView = controller.Create(nameOfItem, price, weight, packed);

      //Assert
      Assert.IsInstanceOfType(indexView, typeof(RedirectToActionResult));
    }

    [TestMethod]
    public void Create_RedirectsToCorrectAction_Index()
    {
      //Arrange
      BagItemsController controller = new BagItemsController();
      string nameOfItem = "camera";
      int price = 1000;
      int weight = 5;
      bool packed = true;
      RedirectToActionResult actionResult = controller.Create(nameOfItem, price, weight, packed) as RedirectToActionResult;

      //Act
      string result = actionResult.ActionName;

      //Assert
      Assert.AreEqual(result, "Index");
    }


    [TestMethod]
    public void Show_HasCorrectModelType_BagItem()
    {
      //Arrange
      BagItemsController controller = new BagItemsController();
      BagItem testBagItem = new BagItem("camera", 1, 2, true);
      ViewResult findView = controller.Show(testBagItem.GetId()) as ViewResult;

      //Act
      var result = findView.ViewData.Model;

      //Assert
      Assert.IsInstanceOfType(result, typeof(BagItem));
    }

    [TestMethod]
    public void Destroy_ReturnsCorrectView_True()
    {
      //Arrange
      BagItemsController controller = new BagItemsController();

      //Act
      ActionResult destroyView = controller.Destroy();

      //Assert
      Assert.IsInstanceOfType(destroyView, typeof(ViewResult));
    }
  }
}
