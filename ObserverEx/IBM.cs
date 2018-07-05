using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverEx
{
  public class IBM
  {
    Investitor[] investitors;

    public IBM(string name, double price)
    {
      
      Price = price;
      investitors = new Investitor[2];
      for (int i = 0; i < 2; i++)
      {
        investitors[i] = new Investitor(name);
      }
    }

    public double Price
    {
      get
      {
        return price;
      }
      set
      {
        price = value;

        Notify();
      }
    }

    public void Attach(Investitor investitor)
    {
      investitors[0] = investitor;
    }

    public void Detach(Investitor investitor)
    {
      investitors[1] = investitor;

    }

    public void Notify()
    {
      if(investitors == null)
      {
        return;
      }
      for(int i=0;i<investitors.Length;i++)
      {
        investitors[i].Update(Price);
      }
    }

    private double price; 
  }
}