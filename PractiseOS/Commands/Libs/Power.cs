using System;


namespace PractiseOS.Commands.Libs
{
    public class Power
    {
        public static void ShutdownPC() 
        {
            Cosmos.System.Power.Shutdown();
        }


        public static void RebootPC()
        {
            Cosmos.System.Power.Reboot();
        }

        

    }
}
