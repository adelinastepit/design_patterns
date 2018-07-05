using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeEx
{
  class Program
  {
    static void Main(string[] args)
    {
      Window window_login = new WindowImpl();
      window_login.Draw();
    }
  }
}
