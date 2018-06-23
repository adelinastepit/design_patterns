using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DirectorBuilder
{
    public class BuilderHtml : Builder
    {
        public BuilderHtml()
        {
        }

        public override void Serialize()
        {
            Console.WriteLine("serialize html");
        }
    }
}