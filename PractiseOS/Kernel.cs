using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using PractiseOS.Commands;
using Cosmos.System.FileSystem;
using Cosmos.System.Graphics;
using Cosmos.System.Network.IPv4;
using Cosmos.System;

namespace PractiseOS
{
    public class Kernel : Sys.Kernel
    {

        private CommandManager commandManager;
        private CosmosVFS vfs;


        public string user;
        protected override void BeforeRun()
        {
            
            System.Console.Clear();
            Canvas canvas;
            this.commandManager = new CommandManager();
            this.vfs = new CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(this.vfs);
            System.Console.WriteLine("AquasisOS booted successfully.");
        }

        protected override void Run()
        {



            var input = System.Console.ReadLine();


            string response;


            response = this.commandManager.processInput(input);
            System.Console.WriteLine(response);



            
        }
    }
}
