using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DirectorBuilder
{
    public class Director
    {
        private SerializationType mType;

        public Director()
        {
        }

        public void Execute()
        {
            Builder pbuilder = null;
            switch(mType)
            {
                case SerializationType.TXT:
                    pbuilder = new BuilderText();
                    break;
                case SerializationType.HTML:
                    pbuilder = new BuilderHtml();
                    break;
                default:
                    break;
            }

            if (pbuilder != null)
            {
                pbuilder.Serialize();
            }
        }

        public void SetType(SerializationType type)
        {
            mType = type;
        }
    }
}