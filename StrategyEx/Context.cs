using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyEx
{
  public class Context
  {
    private SortStrategy _strategy;
    private int[] _arr;
    public Context()
    {
      _strategy = null;
      //
     }

    public void SetStrategy(SortingStrategy type)
    {
      switch(type)
      {
        case SortingStrategy.BUBBLE:
          _strategy = new BubbleSortStrategy();
          break;
        case SortingStrategy.QUICK:
          _strategy = new QuickSortStrategy();
          break;
        default:
          break;
      }
    }

    public void Execute()
    {
      if (_strategy!=null)
      {
        _strategy.Sort(_arr);
      }
    }
  }
}