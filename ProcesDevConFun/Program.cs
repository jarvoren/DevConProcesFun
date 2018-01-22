using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesDevConFun
{
    class Program
    {
        static void Main(string[] args)
        {
            YouTubeTest youTubeTest = new YouTubeTest();
            youTubeTest.InitEnviroment();
            youTubeTest.RunTest();
            youTubeTest.EndTest();

            UsbDevicesTest usbDevicesTest  = new UsbDevicesTest();
            usbDevicesTest.InitEnviroment();
            usbDevicesTest.RunTest();
            usbDevicesTest.EndTest();

        }
    }
}
