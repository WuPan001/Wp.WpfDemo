using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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