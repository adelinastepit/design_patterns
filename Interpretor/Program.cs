using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpretor
{
  class Program
  {
    static void Main(string[] args)
    {

      string roman = "MMX";
      Context context = new Context(roman);

      // Build the 'parse tree'
      List<IExpression> tree = new List<IExpression>();
      tree.Add(new ThousandExpression());
      tree.Add(new HundredExpression());
      tree.Add(new TenExpression());
      tree.Add(new OneExpression());

      // Interpret
      foreach (IExpression exp in tree)
      {
        exp.Interpret(context);
      }

      Console.WriteLine("{0} = {1}",
        roman, context.Output);

      // Wait for user
      Console.ReadKey();
    }
  }
}
