using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerChainResp
{
  class Program
  {
    static void Main(string[] args)
    {
      ConsoleLogger consoleLogger = new ConsoleLogger(LogLevel.DEBUG);
      FileLogger fileLogger = new FileLogger(LogLevel.INFO);

      consoleLogger.WriteMessage();

      consoleLogger.SetNext(fileLogger);

      fileLogger.WriteMessage();

      fileLogger.SetNext(new EmailLogger(LogLevel.ERROR));

    }
  }
}
