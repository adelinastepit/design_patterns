using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StateEx
{
  public class Off : State
  {
    public Off()
    {
      Console.WriteLine("state off");
    }

    public void On(Device device)
    {
      device.SetCurrent(DeviceState.ON);
    }
  }
}