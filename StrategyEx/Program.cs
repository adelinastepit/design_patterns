﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyEx
{
  class Program
  {
    static void Main(string[] args)
    {
      Context context = new Context();

      context.SetStrategy(SortingStrategy.BUBBLE);

      context.Execute();
    }
  }
}
