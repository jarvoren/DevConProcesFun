using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesDevConFun
{
    abstract class TestBase
    {
        public virtual void InitEnviroment() { }

        public static void GetDrivers()
        {

        }

        public virtual void RunTest()
        {
            GetDrivers();
            Console.ReadLine();

        }
        public virtual void EndTest()
        {
            Console.WriteLine("Koniec testu");
        }
    }
}
