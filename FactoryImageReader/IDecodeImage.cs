using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryImageReader
{
  public abstract class IDecodeImage
  {
    public abstract void Decode(ImageReader reader);
  }
}