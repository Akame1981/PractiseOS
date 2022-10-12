using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseOS.Commands
{
    public class DoMath : Command
    {
        public DoMath(string name) : base(name)
        {

        }

        public override string execute(string[] args)
        {

            try
            {
                string operation = args[1];
                double num1 = Convert.ToDouble(args[0]);
                double num2 = Convert.ToDouble(args[2]);

                //Calculation
                try
                {
                    
                    if (operation == "+")
                    {
                        double result = num1 + num2;
                        Console.WriteLine(result);
                    } else if (operation == "-")
                    {
                        double result = num1 - num2;
                        Console.WriteLine(result);
                    }
                    else if (operation == "*")
                    {
                        double result = num1 * num2;
                        Console.WriteLine(result);
                    }
                    else if (operation == "/")
                    {
                        double result = num1 / num2;
                        Console.WriteLine(result);
                    }


                }
                // If error in calculation appears
                catch (Exception e)
                {
                    Console.WriteLine("Error : " + e);
                    
                }
            }
            // If error appears
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e);
                
            }

            return "";

        }
        
    }
}
