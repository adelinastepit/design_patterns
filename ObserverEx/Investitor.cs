using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverEx
{
  public class Investitor
  {
    public Investitor(string name)
    {
      this.name = name;
    }

    public void Update(double price)
    {
      myPrice = price;
      Console.WriteLine("Investitor knows new price " + myPrice);
    }

    private string name;
    private double myPrice;
  }
}