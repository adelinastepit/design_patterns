using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
  public class Type1 : Prototype
  {
    public override Prototype Clone()
    {
      return new Type1();
    }
  }
}