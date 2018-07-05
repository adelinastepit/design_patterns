using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverEx
{
  class Program
  {
    static void Main(string[] args)
    {

      // Create IBM stock and attach investors
      IBM ibm = new IBM("IBM", 111.00);
      ibm.Attach(new Investitor("A"));
      ibm.Attach(new Investitor("B"));

      // Fluctuating prices will notify investors
      ibm.Price = 110.10;
      ibm.Price = 115.00;
      ibm.Price = 110.50;
      ibm.Price = 110.75;

      // Wait for user
      Console.ReadKey();
    }
  }
}
