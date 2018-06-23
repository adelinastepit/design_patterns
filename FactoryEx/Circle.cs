using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryEx
{
    public class Circle : Shape
    {
        public Circle()
        {
        }

        public override void Show()
        {
            Console.WriteLine("Circle");
        }
    }
}
