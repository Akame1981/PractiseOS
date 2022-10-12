using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PractiseOS.Commands
{
    public class Reboot : Command
    {
        public Reboot(string name) : base(name)
        {

        }

        public override string execute(string[] args)
        {

            try
            {
                switch (args[0])
                {
                    default:
                        Libs.Power.RebootPC();
                        break;

                    case "-t":
                        try
                        {

                            Libs.Power.RebootPC();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
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
                        Libs.Power.RebootPC();
                        break;




                }

                Libs.Power.RebootPC();
                return "Error";
            }
            catch (Exception e)
            {
                try
                {
                    Libs.Power.RebootPC();
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
