using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PackerTracker.Models;
using System;

namespace PackerTracker.Tests
{
  [TestClass]
  public class BagItemTest : IDisposable
  {

    public void Dispose()
    {
      BagItem.ClearAll();
    }

    [TestMethod]
    public void BagItemConstructor_CreatesInstanceOfBagItem_BagItem()
    {
      //Arrange
      BagItem testBagItem = new BagItem("camera", 1000, 2, true);

      //Act and Assert
      Assert.AreEqual(typeof(BagItem), testBagItem.GetType());
    }

    [TestMethod]
    public void GetNameOfItem_ReturnsNameOfItem_NameOfItem()
    {
      //Arrange
      string inputNameOfItem = "Camera";
      BagItem testBagItem = new BagItem(inputNameOfItem, 1000, 2, true);

      //Act
      string result = testBagItem.GetNameOfItem();

      //Assert
      Assert.AreEqual("Camera", result);
    }

    [TestMethod]
    public void SetNameOfItem_UpdateNameOfItem_UpdatedNameOfItem()
    {
      //Arrange
      string inputNameOfItem = "Camera";
      BagItem testBagItem = new BagItem(inputNameOfItem, 1000, 2, true);

      //Act
      string updateNameOfItem = "Shoes";
      testBagItem.SetNameOfItem(updateNameOfItem);
      string resultNameOfItem = testBagItem.GetNameOfItem();

      //Assert
      Assert.AreEqual("Shoes", resultNameOfItem);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Price()
    {
      //Arrange
      int inputPrice = 1000;
      BagItem testBagItem = new BagItem( "Camera", inputPrice, 2, true);

      //Act
      int result = testBagItem.GetPrice();

      //Assert
      Assert.AreEqual(1000, result);
    }

    [TestMethod]
    public void SetPrice_UpdatePrice_UpdatedPrice()
    {
      //Arrange
      int inputPrice = 1000;
      BagItem testBagItem = new BagItem("Camera" ,inputPrice, 2, true);

      //Act
      int updatePrice = 500;
      testBagItem.SetPrice(updatePrice);
      int resultPrice = testBagItem.GetPrice();

      //Assert
      Assert.AreEqual(500, resultPrice);
    }

    [TestMethod]
    public void GetWeight_ReturnsWeight_Weight()
    {
      //Arrange
      int inputWeight = 2;
      BagItem testBagItem = new BagItem( "Camera", 1000, inputWeight, true);

      //Act
      int result = testBagItem.GetWeight();

      //Assert
      Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void SetWeight_UpdateWeight_UpdatedWeight()
    {
      //Arrange
      int inputWeight = 2;
      BagItem testBagItem = new BagItem("Camera" , 1000, inputWeight, true);

      //Act
      int updateWeight = 3;
      testBagItem.SetWeight(updateWeight);
      int resultWeight = testBagItem.GetWeight();

      //Assert
      Assert.AreEqual(3, resultWeight);
    }

    [TestMethod]
    public void GetPacked_ReturnsPacked_Bool()
    {
      //Arrange
     bool inputPacked = true;
      BagItem testBagItem = new BagItem("Camera", 1000, 2, inputPacked);

      //Act
     bool result = testBagItem.GetPacked();

      //Assert
      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void SetPacked_UpdatePacked_UpdateWithBool()
    {
      //Arrange
     bool inputPacked = true;
      BagItem testBagItem = new BagItem("Camera", 1000, 2, inputPacked);

      //Act
     bool updatePacked = false;
      testBagItem.SetPacked(updatePacked);
     bool resultPacked = testBagItem.GetPacked();

      //Assert
      Assert.AreEqual(false, resultPacked);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_BagItemList()
    {
      // Arrange
      List<BagItem> newBagItemList = new List<BagItem> { };

      // Act
      List<BagItem> result = BagItem.GetAll();

      // Assert
      CollectionAssert.AreEqual(newBagItemList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsBagItems_BagItemList()
    {
      //Arrange
      string nameOfItem01 = "Camera";
      string nameOfItem02 = "Shoes";
      int inputPrice01 = 500;
      int inputPrice02 = 100;
      int inputWeight01 = 9;
      int inputWeight02 = 10;
      bool packed01 = true;
      bool packed02 = false;
      BagItem newBagItem1 = new BagItem(nameOfItem01, inputPrice01, inputWeight01, packed01);
      BagItem newBagItem2 = new BagItem(nameOfItem02, inputPrice02, inputWeight02, packed02);
      List<BagItem> newBagItemList = new List<BagItem> { newBagItem1, newBagItem2 };

      //Act
      List<BagItem> resultBagItemList = BagItem.GetAll();

      //Assert
      CollectionAssert.AreEqual(newBagItemList, resultBagItemList);
    }

    [TestMethod]
    public void Find_ReturnsCorrectItem_BagItem()
    {
      //Arrange
      string nameOfItem01 = "Camera";
      string nameOfItem02 = "Shoes";
      int inputPrice01 = 500;
      int inputPrice02 = 100;
      int inputWeight01 = 9;
      int inputWeight02 = 10;
      bool packed01 = true;
      bool packed02 = false;
      BagItem newBagItem1 = new BagItem(nameOfItem01, inputPrice01, inputWeight01, packed01);
      BagItem newBagItem2 = new BagItem(nameOfItem02, inputPrice02, inputWeight02, packed02);
      List<BagItem> newBagItemList = new List<BagItem> { newBagItem1, newBagItem2 };

      //Act
      BagItem result = BagItem.Find(2);

      //Assert
      Assert.AreEqual(newBagItem2, result);
    }


  }
}
