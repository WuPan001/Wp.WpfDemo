using NLog;
using System;

namespace Wp.WpfDemo.ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region TestNLog

            var log = LogManager.GetLogger("LoggerName");
            log.Log(LogLevel.Error, new Exception("TestException"), "Tests");

            #endregion TestNLog
        }
    }
}