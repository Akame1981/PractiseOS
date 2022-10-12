using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sys = Cosmos.System;

namespace PractiseOS.Commands.Libs
{
    public class FileManager
    {

        public static void createFile(string Path)
        {
            try
            {
                Sys.FileSystem.VFS.VFSManager.CreateFile(Path.ToString());
            } catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static void deleteFile(string Path)
        {
            try
            {
                if (Sys.FileSystem.VFS.VFSManager.FileExists(Path))
                {
                    Sys.FileSystem.VFS.VFSManager.DeleteFile(Path.ToString());
                } else
                {
                    Console.WriteLine("File does not exist");
                }
                

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }


        public static void createDirectory(string Path)
        {
            try
            {
                Sys.FileSystem.VFS.VFSManager.CreateDirectory(Path);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }

        public static void deleteDirectory(string Path)
        {
            try
            {
                if (Sys.FileSystem.VFS.VFSManager.DirectoryExists(Path))
                {
                    Sys.FileSystem.VFS.VFSManager.DeleteDirectory(Path, true);
                } else
                {
                    Console.WriteLine("Directory does not exist");
                }

                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }


        public static void writeStringToFile(string Path, string text)
        {
            if (Sys.FileSystem.VFS.VFSManager.FileExists(Path))
            {
                try
                {
                    FileStream fs = (FileStream)Sys.FileSystem.VFS.VFSManager.GetFile(Path).GetFileStream();
                    if (fs.CanWrite)
                    {
                        byte[] data = Encoding.ASCII.GetBytes(text.Substring(0, text.Length - 1));
                        fs.Write(data, 0, data.Length);
                        fs.Close();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            } else
            {
                Console.WriteLine("File does not exist");
            }

        }

        public static void readFromFile(string Path)
        {
            string response;
            try
            {
                if (Sys.FileSystem.VFS.VFSManager.FileExists(Path))
                {
                    FileStream fs = (FileStream)Sys.FileSystem.VFS.VFSManager.GetFile(Path).GetFileStream();
                    if (fs.CanRead)
                    {
                        byte[] data = new Byte[256];
                        fs.Read(data, 0, data.Length);
                        response = Encoding.ASCII.GetString(data);
                        fs.Close();


                    }
                    else
                    {
                        response = "cannot read file!";
                    }
                    Console.WriteLine(response);
                } else
                {
                    Console.WriteLine("File does not exist");
                }

                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }



        public static void listDrives()
        {
            try
            {
                List<string> drives = Sys.FileSystem.VFS.VFSManager.GetLogicalDrives();
                foreach (string d in drives)
                {
                    Console.WriteLine(d);
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }



        public static void getFreeSpaceAvailable(string drive)
        {
            try
            {
                long space = Sys.FileSystem.VFS.VFSManager.GetAvailableFreeSpace(drive);
                Console.WriteLine(space);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static void listDirectories(string path)
        {
            try
            {
                List<Cosmos.System.FileSystem.Listing.DirectoryEntry> h = Sys.FileSystem.VFS.VFSManager.GetDirectoryListing(path);
                foreach (Cosmos.System.FileSystem.Listing.DirectoryEntry a in h)
                {
                    Console.WriteLine(a.mFullPath);
                   

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }



        public static void checkIfDirectoryExists(string Path)
        {
            
        }

    }
}
