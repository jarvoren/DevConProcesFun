using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesDevConFun
{
    class UsbDevicesTest : TestBase
    {
        public override void InitEnviroment()
        {
            base.InitEnviroment();
        }

        public override void RunTest()
        {
            base.RunTest();

            Process proc = new Process
            {
                StartInfo = new ProcessStartInfo()
                {
                    FileName = fileName,
                    WorkingDirectory = devConPath,
                    Arguments = "disable *usb*hub*",
                    CreateNoWindow = true,
                    //WindowStyle = ProcessWindowStyle.Hidden
                }
            };
            proc.Start();

            proc = new Process
            {
                StartInfo = new ProcessStartInfo()
                {
                    FileName = fileName,
                    WorkingDirectory = devConPath,
                    Arguments = "enable *usb*hub*",
                    CreateNoWindow = true,
                    //WindowStyle = ProcessWindowStyle.Hidden
                }
            };
            proc.Start();
           

            Console.ReadLine();
        }

        public override void EndTest()
        {
            base.EndTest();
        }
    }
}
