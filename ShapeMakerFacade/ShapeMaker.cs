using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeMakerFacade
{
  public class ShapeMaker
  {
    private Triangle mTriangle;
    private Rectangle mRectangle;

    public ShapeMaker()
    {
    }

    public void CreateTriangle()
    {
      mTriangle = new Triangle();
    }

    public void CreateRectangle()
    {
      mRectangle = new Rectangle();
    }

    public void DrawTriangle()
    {
      mTriangle.draw();
    }
  }
}