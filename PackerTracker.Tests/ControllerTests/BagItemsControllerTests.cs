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
    public void Show_HasCorrectModelType_BagItem()
    {
      //Arrange
      int id = 1;
      BagItemsController controller = new BagItemsController();
      ViewResult findView = controller.Show(id) as ViewResult;

      //Act
      var result = findView.ViewData.Model;
      // var result2 = findView.ViewData[""];

      //Assert
      // Assert.IsInstanceOfType(result2, typeof(BagItem));
      Assert.IsInstanceOfType(result, typeof(BagItem));
    }


  }

}
