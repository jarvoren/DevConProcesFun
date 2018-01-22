using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesDevConFun
{
    abstract class TestBase
    {
        protected static string devConPath  = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\Windows Kits\10\Tools\x64";
        protected static string fileName    = "devcon.exe";

        public virtual void InitEnviroment() { }

        public static void GetDrivers()
        {
            Process proc = new Process
            {
                StartInfo = new ProcessStartInfo()
                {
                    FileName = fileName,
                    WorkingDirectory = devConPath,
                    Arguments = "driverfiles *",
                    CreateNoWindow = true,
                    //WindowStyle = ProcessWindowStyle.Hidden
                }
            };
            proc.Start();
            
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
