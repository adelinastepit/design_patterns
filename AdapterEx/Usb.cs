using System;


namespace AdapterEx
{
  public class Usb
  {
    public Usb()
    {
    }

    public string Port
    {
      get => default(string);
      set
      {
      }
    }

    public void PlugInUSB()
    {
      Console.WriteLine("Plug in usb");
    }
  }

  public class Monitor
  {
    public Monitor()
    {
    }

    public string Port
    {
      get => default(string);
      set
      {
      }
    }

    public void PlugInMonitor()
    {
      Console.WriteLine("Plug in monitor");
    }
  }
}