using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryEx
{
    public class Ellipse : Shape
    {
        public Ellipse()
        {
        }

        public override void Show()
        {
            Console.WriteLine("Ellipse");
        }
    }
}