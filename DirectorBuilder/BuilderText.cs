using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DirectorBuilder
{
    public class BuilderText : Builder
    {
        public BuilderText()
        {
        }

        public override void Serialize()
        {
            Console.WriteLine("serialize text");
        }
    }
}