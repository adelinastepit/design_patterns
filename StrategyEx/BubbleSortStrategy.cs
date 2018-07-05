﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyEx
{
  public class BubbleSortStrategy : SortStrategy
  {
    public BubbleSortStrategy()
    {
    }

    public override void Sort(int[] arr)
    {
      Console.WriteLine("Bubble");
    }
  }
}