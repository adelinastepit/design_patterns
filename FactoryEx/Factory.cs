using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryEx
{
    public class Factory : IFactory
    {
        public Circle CreateCircle()
        {
            return new Circle();
        }

        public Rectangle CreateRectangle()
        {
            return new Rectangle();
        }

        public Ellipse CreateEllipse()
        {
            return new Ellipse();
        }
    }
}