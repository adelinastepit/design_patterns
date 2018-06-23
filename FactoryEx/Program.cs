using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryEx
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new Factory();

            Circle circle = factory.CreateCircle();
            circle.Show();

            Ellipse ellipse = factory.CreateEllipse();
            ellipse.Show();

            Rectangle rectangle = factory.CreateRectangle();
            rectangle.Show();
        }
    }
}
