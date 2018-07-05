using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterEx
{
  public class Adaptee
  {
    public Adaptee()
    {
      usb_device = new Usb();
      monitor_device = new Monitor();
      SetMonitorPort();
      SetUsbPort();
    }

    public void SetUsbPort()
    {
      usb_device.Port = "USB";
    }

    public void SetMonitorPort()
    {
      monitor_device.Port = "HDMI";
    }

    public void PlugInUSB()
    {
      usb_device.PlugInUSB();
    }

    public void PlugInMonitor()
    {
      monitor_device.PlugInMonitor();
    }

    private Usb usb_device;
    private Monitor monitor_device;
 
  }
}