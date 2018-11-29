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


  }

}
