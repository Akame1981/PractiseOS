using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseOS.Commands
{
    public class Help : Command
    {
        public Help(string name) : base(name)
        {

        }

        public override string execute(string[] args)
        {

            try
            {



                switch (args[0])
                {
                    default:
                        Console.WriteLine("Welcome to " + Libs.OSInfo.OSName + " | OSVersion : " + Libs.OSInfo.OSVersion + " | If you want to see all commands type \"help -commands\"");
                        break;

                    case "-commands":
                        Console.WriteLine("All Commands : ");
                        Console.WriteLine("\"calc\" - Do math");
                        Console.WriteLine("\"shutdown\" - Shutdown the pc");
                        Console.WriteLine("\"quit\" - Shutdown the pc");
                        Console.WriteLine("\"reboot\" - Reboot the pc");
                        Console.WriteLine("\"restart\" - Reboot the pc");
                        Console.WriteLine("\"sysinfo\" - Get information about the OS and Hardware of this pc");
                        Console.WriteLine("\"file\" - use filemanager");
                        Console.WriteLine("Type \"help -cmd {command}\" to view more about the command");
                        break;

                    case "-cmd":
                        if (args[1] == "calc")
                        {
                            Console.WriteLine("\"calc\" is used to do math.");
                            Console.WriteLine("Example : \"calc 4 + 7\"");
                            Console.WriteLine("You can use these operations for now :  +    -    *    / ");
                            Console.WriteLine("The structure of command should be \"calc {number} {operation} {number}\"");
                        }

                        if (args[1] == "shutdown")
                        {
                            Console.WriteLine("\"shutdown\" is used to shut down your pc.");
                            Console.WriteLine("Example : \"shutdown\"");
                            Console.WriteLine("Available arguments : ");
                            Console.WriteLine("{-t (time in ms)} - shuts down pc after time");
                            Console.WriteLine("{-message (message)} - displays message before shutdown");
                        }
                        if (args[1] == "quit")
                        {
                            Console.WriteLine("\"quit\" is used to shut down your pc.");
                            Console.WriteLine("Example : \"quit\"");
                            Console.WriteLine("Available arguments : ");
                            Console.WriteLine("{-t (time in ms)} - shuts down pc after time");
                            Console.WriteLine("{-message (message)} - displays message before shutdown");
                        }
                        if (args[1] == "reboot")
                        {
                            Console.WriteLine("\"reboot\" is used to reboot your pc.");
                            Console.WriteLine("Example : \"reboot\"");
                            Console.WriteLine("Available arguments : ");
                            Console.WriteLine("{-t (time in ms)} - reboots pc after time");
                            Console.WriteLine("{-message (message)} - displays message before reboot");
                        }
                        if (args[1] == "restart")
                        {
                            Console.WriteLine("\"restart\" is used to shut down your pc.");
                            Console.WriteLine("Example : \"restart\"");
                            Console.WriteLine("Available arguments : ");
                            Console.WriteLine("{-t (time in ms)} - restarts pc after time");
                            Console.WriteLine("{-message (message)} - displays message before restart");

                        }


                        if (args[1] == "sysinfo")
                        {
                            Console.WriteLine("\"sysinfo\" is used to show information about the OS and Hardware of this pc.");
                            Console.WriteLine("Example : \"sysinfo\"");

                        }



                        if (args[1] == "file")
                        {
                            Console.WriteLine("\"file\" is used to controll file manager.");
                            Console.WriteLine("Example : \"file create 0:"+ @"\" +"hello.txt\"");
                            Console.WriteLine("Available arguments : ");
                            Console.WriteLine("{create (path)} - creates file");
                            Console.WriteLine("{delete (path)} - deletes file");
                            Console.WriteLine("{createdir (path)} - creates directory");
                            Console.WriteLine("{deletedir (path)} - deletes directory");
                            Console.WriteLine("{writestr (path) (text)} - writes text to file");
                            Console.WriteLine("{readstr (path)} - read a file");
                            Console.WriteLine("{listdrives} - lists all drives");
                        }
                        break;


                }


                return "";
            } catch(Exception e)
            {
                try
                {
                    return "Welcome to " + Libs.OSInfo.OSName + " | OSVersion : " + Libs.OSInfo.OSVersion + " | If you want to see all commands type \"help -commands\"";
                }
                catch
                {
                    return e.ToString();
                }
            }
        }

    }
}
