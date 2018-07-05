using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoggerChainResp
{
  public class ConsoleLogger : Logger
  {
    public ConsoleLogger(LogLevel logLevel): base(logLevel)
    {
    }

    public override void WriteMessage()
    {
      Console.WriteLine(mLevel+"Console logger");
    }
  }
}