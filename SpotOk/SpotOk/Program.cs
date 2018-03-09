using log4net;
using log4net.Config;
using SpotOk.Ok;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpotOk
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlConfigurator.Configure(new FileInfo("log4net.config"));
            ILog logger = LogManager.GetLogger("program");

            //AccountConfig.init("yxq");

            //Console.WriteLine($"{AccountConfig.mainAccountId}， {AccountConfig.accessKey}， {AccountConfig.secretKey}， {AccountConfig.sqlConfig}");
            logger.Error("-------------------------- 软件账户配置完成 ---------------------------------");

            Console.WriteLine("输入1：测试，2：正式运行");
            var choose = Console.ReadLine();
            if (choose == "1")
            {
                Test.Testing();
            }
            else
            {
                Run();
            }

            Console.WriteLine("输入任意推出");
            Console.ReadLine();

            Console.ReadLine();
        }

        public static void Run()
        {
            while (true)
            {
                foreach (var coin in Utils.GetUsdt())
                {
                    if (coin == "btc")
                    {
                        continue;
                    }
                    Thread.Sleep(1000);
                    CoinTrade.Start(coin);
                }
            }
        }
    }
}
