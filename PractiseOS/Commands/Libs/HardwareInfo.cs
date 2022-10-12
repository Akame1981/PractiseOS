using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Sys = Cosmos.System;

namespace PractiseOS.Commands.Libs
{
    public class HardwareInfo
    {



        public static string cpuBrand = Cosmos.Core.CPU.GetCPUBrandString();
        public static ulong cpuUptime = Cosmos.Core.CPU.GetCPUUptime();
        public static string macAdress = Cosmos.HAL.Network.MACAddress.Broadcast.ToString();
        public static uint RamAmountMB = Cosmos.Core.CPU.GetAmountOfRAM();
        public static double RamAmountGB = Convert.ToInt32(RamAmountMB) / 1024;
        public static List<Cosmos.HAL.NetworkDevice> networkDevices = Cosmos.HAL.NetworkDevice.Devices;






    }
}
