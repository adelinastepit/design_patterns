using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgeEx
{
  public class RemoteControl : Switch
  {
    public RemoteControl()
    {
      tv = new TV();
      airConditioner = new AirConditioner();
    }

    public void TurnOn()
    {
      tv.TurnOn();
      airConditioner.TurnOn();
    }

    protected TV tv;
    protected AirConditioner airConditioner;
  }
}