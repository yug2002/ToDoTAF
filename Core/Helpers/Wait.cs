using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Helpers
{
    public class Wait
    {
        private const int DefaultTimeOutMs = 60000;

        private const int RetryIntervalMs = 250;

        public const int DebounceTimeOut = 400;

        public static void For(Func<bool> condition, int timeOut = DefaultTimeOutMs)
        {
            var startTime = DateTime.Now;
            while (DateTime.Now.Subtract(startTime).TotalMilliseconds < timeOut)
            {
                try
                {
                    if (condition())
                    {
                        return;
                    }
                }
                catch (StaleElementReferenceException e)
                {
                    throw e;
                }
                catch (Exception)
                {
                    // skip
                }
                
                TaskDelay(RetryIntervalMs);
            }
        }

        public static void TaskDelay(int milliseconds)
        {
            PutTaskDelay(milliseconds).Wait();
        }

        private static async Task PutTaskDelay(int milliseconds)
        {
            await Task.Delay(milliseconds);
        }
    }
}
