using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseOS.Commands
{
    public class CommandManager
    {
        private List<Command> commands;

        public CommandManager()
        {
            this.commands = new List<Command>(1);

            //Add new commands
            this.commands.Add(new Help("help"));

            // Basic
                // Power
                    this.commands.Add(new Shutdown("shutdown"));
                    this.commands.Add(new Shutdown("quit"));
                    this.commands.Add(new Reboot("reboot"));
                    this.commands.Add(new Reboot("restart"));
                //Math
                    this.commands.Add(new DoMath("calc"));
                //Get SystemInfo
                    this.commands.Add(new GetSystemInfo("sysinfo"));
                //Usefull stuff
                    this.commands.Add(new Clear("cls"));
                    this.commands.Add(new Clear("clear"));
            // FileManager 
                // file 
                    this.commands.Add(new File("file"));
                    this.commands.Add(new ChangeDirectory("cd"));
            
        }

        public string processInput(string input)
        {
            //Command
            string[] split = input.Split(" ");

            //First word of command
            string label = split[0];

            List<string> args = new List<string>();

            //Number of arguments
            int ctr = 0;
            foreach(string s in split)
            {

                if (ctr != 0)
                {
                    args.Add(s);
                }
                ++ctr;
            }


            foreach(Command cmd in this.commands)
            {
                // Check if command exists
                if(cmd.name == label){
                   return cmd.execute(args.ToArray());
                }
            }

            //If invalid command
            return "Invalid Command : " + label;
        }
    }
}
