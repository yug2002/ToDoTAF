using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Helpers
{
    public class Log : ILog
    {
        private Logger Logger => LogManager.GetCurrentClassLogger();

        public void Debug(string text)
        {
            Logger.Debug(text);
        }

        public void Info(string text)
        {
            Logger.Info(text);
        }

        public void Error(string text)
        {
            Logger.Error(text);
        }

        public void Warn(string text)
        {
            Logger.Warn(text);
        }
    }
}
