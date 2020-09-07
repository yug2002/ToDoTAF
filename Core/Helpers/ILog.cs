using NLog;

namespace Core.Helpers
{
    public interface ILog
    {
        Logger Logger { get; }
    }
}