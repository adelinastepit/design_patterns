using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryEx
{
    interface IFactory
    {
        Circle CreateCircle();
        Rectangle CreateRectangle();
        Ellipse CreateEllipse();
    }
}
