using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterEx
{
  public class Adaptor : Target
  {
    public Adaptor(string port)
    {
      adaptee = new Adaptee();
      mPort = port;
    }
    public override void PlugIn()
    {
      if (mPort == "USB")
      {
        adaptee.PlugInUSB();
      }
      else
      {
        adaptee.PlugInMonitor();
      }
    }

    public void SetObjects()
    {
      throw new System.NotImplementedException();
    }

    private Adaptee adaptee;
    private string mPort;
  }
}