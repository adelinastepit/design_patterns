using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StateEx
{
  public class Device
  {
    private State _state;
    private string _name;
    public Device(string name)
    {
      _name = name;
    }

    public void SetCurrent(DeviceState deviceState)
    {
      switch(deviceState)
      {
        case DeviceState.ON:
          _state = new On();
          break;
        case DeviceState.OFF:
          _state = new Off();
          break;
        default:
          break;
      }
    }
  }
}