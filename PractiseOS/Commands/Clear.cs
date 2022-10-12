using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseOS.Commands
{
    public class Clear : Command
    {
        public Clear(string name) : base(name)
        {

        }

        public override string execute(string[] args)
        {
            Console.Clear();
            return "";
        }
    }
}
