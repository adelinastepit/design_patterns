using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMakerFacade
{
  class Program
  {
    static void Main(string[] args)
    {
      ShapeMaker shape_maker = new ShapeMaker();

      shape_maker.CreateRectangle();
      shape_maker.CreateTriangle();
      shape_maker.DrawTriangle();
    }
  }
}
