using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseOS.Commands
{
    public class ChangeDirectory:Command
    {

        public static string curdir = "";
        public ChangeDirectory(string name) : base(name)
        {

        }

        public override string execute(string[] args)
        {
            if (Cosmos.System.FileSystem.VFS.VFSManager.DirectoryExists(args[0]))
            {
                curdir = args[0];
                return "Current directory : " + args[0] ;
            }
            return "Directory not found";

        }
    }
}
