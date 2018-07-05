using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateEx
{
  class Program
  {
    static void Main(string[] args)
    {
      Device device = new Device("device 1");
      device.SetCurrent(DeviceState.ON);
      device.SetCurrent(DeviceState.OFF);
    }
  }
}
