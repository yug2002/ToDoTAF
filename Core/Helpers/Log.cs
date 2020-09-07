using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Helpers
{
    public class Log : ILog
    {
        public Logger Logger => LogManager.GetCurrentClassLogger();
    }
}
