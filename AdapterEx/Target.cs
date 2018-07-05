using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterEx
{
  public abstract class Target
  {
    public Target()
    {
    }

    public abstract void PlugIn();

    public void SetObjects()
    {
      //...
    }
  }
}