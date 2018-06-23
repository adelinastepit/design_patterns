using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DirectorBuilder
{
    public abstract class IBuilder
    {
        public abstract void Serialize();
    }

    public class Builder : IBuilder
    {
        public Builder()
        {
        }

        public override void Serialize()
        {
        }
    }
}