using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesDevConFun
{
    class YouTubeTest : TestBase
    {
        string link;

        public override void InitEnviroment()
        {
            base.InitEnviroment();

            link = "https://www.youtube.com/watch?v=V-zXT5bIBM0";

        }

        public override void RunTest()
        {
            base.RunTest();
            
            Process.Start(link);

            Console.ReadLine();
        }

        public override void EndTest()
        {
            base.EndTest();
        }
    }
}
