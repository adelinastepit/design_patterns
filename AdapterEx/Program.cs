using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterEx
{
  class Program
  {
    static void Main(string[] args)
    {
      Target target1 = new Adaptor("USB");

      target1.PlugIn();

      Target target2 = new Adaptor("HDMI");
      target2.PlugIn();

      target2.SetObjects();
    }
  }
}
