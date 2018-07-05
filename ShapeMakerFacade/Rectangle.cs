using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeMakerFacade
{
  public class Rectangle : Shape
  {
    public Rectangle()
    {
    }

    public override void draw()
    {
      Console.WriteLine("rectangle");
    }
  }
}