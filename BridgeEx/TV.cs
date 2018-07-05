using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgeEx
{
  public class TV : Device
  {
    public TV()
    {
    }

    public override void TurnOn()
    {
      Console.WriteLine("TV ON");
    }
  }
}