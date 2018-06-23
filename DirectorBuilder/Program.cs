using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            director.SetType(SerializationType.TXT);
            director.Execute();
        }
    }
}
