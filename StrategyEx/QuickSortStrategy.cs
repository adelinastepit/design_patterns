using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyEx
{
  public class QuickSortStrategy : SortStrategy
  {
    public QuickSortStrategy()
    {
    }

    public override void Sort(int[] arr)
    {
      Console.WriteLine("Quick");
    }
  }
}