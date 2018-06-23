using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
  public class Factory
  {
    public Type1 GetType1()
    {
      Type1 type1 = new Type1();
      return (Type1)type1.Clone();
    }

    public Type2 GetType2()
    {
      Type2 type2 = new Type2();
      return (Type2)type2.Clone();
    }
  }
}