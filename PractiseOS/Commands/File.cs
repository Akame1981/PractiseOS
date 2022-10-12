using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sys = Cosmos.System;
using System.Threading.Tasks;
using System.IO;

namespace PractiseOS.Commands
{
    public class File : Command
    {
        public File(string name) : base(name)
        {

        }

        public override string execute(string[] args)
        {
            string response = "";
            switch (args[0])
            {
                
                case "create":
                    try
                    {
                        Libs.FileManager.createFile(ChangeDirectory.curdir + args[1]);
                        response = "File sucsessfully created : " + args[1];
                    }
                    catch(Exception e)
                    {
                        response = e.ToString() + args[1];
                        break;
                    }
                break;
                case "delete":
                    try
                    {
                        Libs.FileManager.deleteFile(ChangeDirectory.curdir + args[1]);
                        response = "File sucsessfully deleted : " + args[1];
                    }
                    catch (Exception e)
                    {
                        response = e.ToString();
                        break;
                    }


                    break;


                case "createdir":
                    try
                    {
                        Libs.FileManager.createFile(ChangeDirectory.curdir + args[1]);
                        response = "Directory sucsessfully created : " + args[1];
                    }
                    catch (Exception e)
                    {
                        response = e.ToString() + args[1];
                        break;
                    }


                    break;

                case "deletedir":
                    try
                    {
                        Libs.FileManager.deleteDirectory(ChangeDirectory.curdir + args[1]);
                        response = "Directory sucsessfully deleted : " + args[1];
                    }
                    catch (Exception e)
                    {
                        response = e.ToString();
                        break;
                    }
                    break;

                    case"writestr":
                    try
                    {
                        int ctr = 0;
                        StringBuilder sb = new StringBuilder();

                        foreach (string s in args)
                        {
                            if (ctr > 1)
                            {

                                sb.Append(s + " ");
                            }

                            ++ctr;
                        }
                        string txt = sb.ToString();
                        Libs.FileManager.writeStringToFile(ChangeDirectory.curdir + args[1], txt);
                        response = "succsess";
                    }
                    catch(Exception e){
                        response = e.ToString();
                    }
                        
                        break;


                case "readstr":
                    try
                    {
                        Libs.FileManager.readFromFile(ChangeDirectory.curdir + args[1]);
                    }
                    catch (Exception e)
                    {
                        response = e.ToString();
                    }
                    break;



                case "listdrives":
                    try
                    {
                        Libs.FileManager.listDrives();
                    }
                    catch (Exception e)
                    {
                        response = e.ToString();
                    }
                    break;



                case "listdir":
                    try
                    {
                        Libs.FileManager.listDirectories(ChangeDirectory.curdir + args[1]);
                    }
                    catch (Exception e)
                    {
                        response = e.ToString();
                    }
                    break;

                case "freespace":
                    try
                    {
                        Libs.FileManager.getFreeSpaceAvailable(ChangeDirectory.curdir + args[1]);
                    }
                    catch (Exception e)
                    {
                        response = e.ToString();
                    }
                    break;





                default:
                    response = "Unexepected argument : " + args[0];

                    break;




            }
            return response;
        }
    }
}
