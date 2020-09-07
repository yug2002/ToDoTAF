using NLog;

namespace Core.Helpers
{
    public interface ILog
    {
        void Debug(string text);

        void Info(string text);

        void Error(string text);

        void Warn(string text);
       
    }
}