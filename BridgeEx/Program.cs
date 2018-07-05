using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeEx
{
  class Program
  {
    static void Main(string[] args)
    {
      Switch switch_device = new RemoteControl();

      switch_device.TurnOn();
    }
  }
}
