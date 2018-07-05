using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgeEx
{
  public class AirConditioner : Device
  {
    public AirConditioner()
    {
    }

    public override void TurnOn()
    {
      Console.WriteLine("Air conditioner ON");
    }
  }
}