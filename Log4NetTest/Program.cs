using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Log4NetTest
{
    class Program
    {
        static void Main(string[] args)
        {

            log4net.Config.XmlConfigurator.Configure();

            log4net.ILog log = log4net.LogManager.GetLogger("Test");

            while(true)
            {
                log.Info("AAA");
                Thread.Sleep(10);
            }

            

            Console.ReadKey();

        }
    }
}
