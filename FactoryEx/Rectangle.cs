using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryEx
{
    public class Rectangle : Shape
    {
        public Rectangle()
        {
        }

        public override void Show()
        {
            Console.WriteLine("Rectangle");
        }
    }
}