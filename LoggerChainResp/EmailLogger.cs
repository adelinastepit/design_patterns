using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoggerChainResp
{
  public class EmailLogger : Logger
  {
    public EmailLogger(LogLevel logLevel) : base(logLevel)
    {
    }

    public override void WriteMessage()
    {
    }
  }
}