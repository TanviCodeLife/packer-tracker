using System;
using System.Collections.Generic;

namespace PackerTracker.Models
{

  public class BagItem
  {
    private string _nameOfItem;
    private int _price;
    private int _weight;
    private bool _packed;
    private int _id;
    private static List<BagItem> _instances = new List<BagItem> {};

    public BagItem(string nameOfItem, int price, int weight, bool packed)
    {
      _nameOfItem = nameOfItem;
      _price = price;
      _weight = weight;
      _packed = packed;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public string GetNameOfItem()
    {
      return _nameOfItem;
    }

    public void SetNameOfItem(string newNameOfItem)
    {
      _nameOfItem = newNameOfItem;
    }

    public int GetPrice()
    {
      return _price;
    }

    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }

    public int GetWeight()
    {
      return _weight;
    }

    public void SetWeight(int newWeight)
    {
      _weight = newWeight;
    }

    public bool GetPacked()
    {
      return _packed;
    }

    public void SetPacked(bool newPacked)
    {
      _packed = newPacked;
    }

    public int GetId()
    {
      return _id;
    }

    public static BagItem Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public static List<BagItem> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }

}
