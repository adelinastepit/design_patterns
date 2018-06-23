using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryImageReader
{
  public abstract class ImageReader
  {
    public ImageReader()
    {
    }

    public abstract void GetType();
  }
}