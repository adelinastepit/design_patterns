using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoggerChainResp
{
  public abstract class Logger
  {
    protected LogLevel mLevel;
    protected Logger nextLogger;

    public Logger(LogLevel logLevel)
    {
      mLevel = logLevel;
    }

    public abstract void WriteMessage();

    public void SetNext(Logger logger)
    {
      nextLogger = logger;
    }
  }
}