using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class TestLogging
    {
        private static readonly ILog testLoger =
    LogManager.GetLogger(typeof(TestLogging));

        static void Main(string[] args)
        {
            BasicConfigurator.Configure();
            testLoger.Debug("Debug msg");
            testLoger.Error("Error msg");

        }
    }
}
