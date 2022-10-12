using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sys = Cosmos.System;

namespace PractiseOS.Commands
{
    public class GetSystemInfo : Command
    {
        public GetSystemInfo(string name) : base(name)
        {

        }

        public override string execute(string[] args)
        {
            try
            {

                Console.WriteLine("------------System Info------------");
                Console.WriteLine("OS Name : " + Libs.OSInfo.OSName);
                Console.WriteLine("OS Version : " + Libs.OSInfo.OSVersion);
                Console.WriteLine("OS Build : " + Libs.OSInfo.OSBuild);
                Console.WriteLine();
                Console.WriteLine("CPU : " + Libs.HardwareInfo.cpuBrand);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("MAC Adress : " + Libs.HardwareInfo.macAdress);
                Console.WriteLine();
                Console.WriteLine("Ram : " + Libs.HardwareInfo.RamAmountMB + "MB");
                Console.WriteLine("Ram : " + Libs.HardwareInfo.RamAmountGB + "GB");
                Console.WriteLine();
                Console.WriteLine("Network Devices : " + Libs.HardwareInfo.networkDevices.ToString());

            } catch(Exception e)
            {
                Console.WriteLine(e);
            }


            return "";
        }
    }
}
