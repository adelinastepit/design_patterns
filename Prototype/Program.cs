using System;


namespace Prototype
{
  class Program
  {
    static void Main(string[] args)
    {
      Factory factory = new Factory();
      Type1 obj1 = factory.GetType1();
      Type2 obj2 = factory.GetType2();

      Console.WriteLine(obj1.GetType());
      Console.WriteLine(obj2.GetType());

    }
  }
}
