using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StateEx
{
  public class On : State
  {
    public On()
    {
      Console.WriteLine("state on");
    }

    public void Off(Device device)
    {
      device.SetCurrent(DeviceState.OFF);
    }
  }
}