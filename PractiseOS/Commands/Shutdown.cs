using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PractiseOS.Commands
{
    public class Shutdown : Command
    {
        public Shutdown(string name) : base(name)
        {

        }

        public override string execute(string[] args)
        {
            try
            {
                switch (args[0])
                {
                    default:
                        Libs.Power.ShutdownPC();
                        break;

                    case "-t":
                        Thread.Sleep(Convert.ToInt32(args[1]));
                        Libs.Power.ShutdownPC();
                        break;

                    case "-message":
                        int ctr = 0;
                        StringBuilder sb = new StringBuilder();

                        foreach (string s in args)
                        {
                            if (ctr > 0)
                            {
                                sb.Append(s + " ");
                            }

                            ++ctr;
                        }
                        string txt = sb.ToString();
                        Console.WriteLine(txt);
                        Console.ReadLine();
                        Libs.Power.ShutdownPC();
                        break;


                }

                Libs.Power.ShutdownPC();
                return "Error";
            } catch (Exception e)
            {
                try
                {
                    Libs.Power.ShutdownPC();
                    return "";
                }
                catch
                {
                    return e.ToString();
                }
                
            }


        }


    }
}
