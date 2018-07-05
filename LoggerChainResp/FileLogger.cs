using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoggerChainResp
{
  public class FileLogger : Logger
  {
    public FileLogger(LogLevel logLevel) : base(logLevel)
    {

    }

    public override void WriteMessage()
    {
      Console.WriteLine(mLevel+"file logger msg");
    }
  }
}