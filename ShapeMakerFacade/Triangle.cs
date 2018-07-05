using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeMakerFacade
{
  public class Triangle : Shape
  {
    public Triangle()
    {
    }

    public override void draw()
    {
      Console.WriteLine("draw triangle");
    }
  }
}