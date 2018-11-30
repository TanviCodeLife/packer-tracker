using System;
using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class Bag
  {
    private static List<Bag> _instances = new List<Bag>{};
    private string _name;
    private int _id;
    private List<BagItem> _bagItems;

    public Bag(string bagName)
    {
      _name = bagName;
      _instances.Add(this);
      _id = _instances.Count;
      _bagItems = new List<BagItem>{};
    }

    public string GetBagName()
    {
      return _name;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Bag> GetAll()
    {
      return _instances;
    }

    public static Bag Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public List<BagItem> GetBagItems()
    {
      // Bag newBag = new Bag("Clutch");
      // BagItem newBagItem = new BagItem("cookies", 1, 2, true);
      // _bagItems = new List<BagItem>{ newBagItem };
      // return _bagItems;
      // Failure Code
      return _bagItems;
    }

    public void AddBagItem(BagItem bagItem)
    {
      _bagItems.Add(bagItem);
    }

  }
}
