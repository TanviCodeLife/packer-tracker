using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackerTracker.Models;
using System.Collections.Generic;
using System;

namespace PackerTracker.Tests
{
  [TestClass]
  public class BagTest : IDisposable
  {

    public void Dispose()
    {
      Bag.ClearAll();
    }

    [TestMethod]
    public void BagConstructor_CreatesInstanceOfBag_Bag()
    {
      Bag newBag = new Bag("test bag");
      Assert.AreEqual(typeof(Bag), newBag.GetType());
    }

    [TestMethod]
    public void GetBagName_ReturnsBagName_String()
    {
      //Arrange
      string name = "Test Bag";
      Bag newBag = new Bag(name);

      //Act
      string result = newBag.GetBagName();

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllBagObjects_BagList()
    {
      //Arrange
      string name01 = "Clutch";
      string name02 = "Purse";
      Bag newBag1 = new Bag(name01);
      Bag newBag2 = new Bag(name02);
      List<Bag> newList = new List<Bag> { newBag1, newBag2 };

      //Act
      List<Bag> result = Bag.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectBag_Bag()
    {
      //Arrange
      string name01 = "Clutch";
      string name02 = "Purse";
      Bag newBag1 = new Bag(name01);
      Bag newBag2 = new Bag(name02);

      //Act
      Bag result = Bag.Find(2);

      //Assert
      Assert.AreEqual(newBag2, result);
    }

    [TestMethod]
    public void GetBagItems_ReturnsEmptyBagItemList_BagItemList()
    {
      //Arrange
      string name = "Clutch";
      Bag newBag = new Bag(name);
      List<BagItem> newBagItemList = new List<BagItem> { };

      //Act
      List<BagItem> result = newBag.GetBagItems();
      // Check result List contents
      // foreach(BagItem item in result)
      // {
      //   Console.WriteLine(item.GetNameOfItem());
      // }

      //Assert
      CollectionAssert.AreEqual(newBagItemList, result);
    }

    [TestMethod]
    public void AddBagItem_AssociatesBagItemWithBag_BagItemList()
    {
      //Arrange
      string nameOfItem01 = "Camera";
      int inputPrice01 = 500;
      int inputWeight01 = 9;
      bool packed01 = true;
      BagItem newBagItem = new BagItem(nameOfItem01, inputPrice01, inputWeight01, packed01);
      List<BagItem> newBagItemList = new List<BagItem> { newBagItem }; //Expected List

      //Act
      string name = "Clutch";
      Bag newBag = new Bag(name);
      newBag.AddBagItem(newBagItem);
      List<BagItem> result = newBag.GetBagItems(); //Actual List

      //Assert
      CollectionAssert.AreEqual(newBagItemList, result);
    }


  }
}
