using NLog;
using NLog.Targets;
using NUnit.Framework;

namespace Core
{
    [Target("TestOutput")]
    public class TestOutputTarget : TargetWithLayout
    {
        protected override void Write(LogEventInfo logEvent)
        {
            string logMessage = this.Layout.Render(logEvent);
            TestContext.Out.WriteLine(logMessage);
        }
    }
}
