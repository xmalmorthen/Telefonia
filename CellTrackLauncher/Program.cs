using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace CellTrackLauncher
{
    class Program
    {
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

        static void Main(string[] args)
        {
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);
            try
            {                
                string path = Directory.GetCurrentDirectory();                
                Environment.CurrentDirectory = (path);
                if (path.Equals(Directory.GetCurrentDirectory())) {
                    System.Diagnostics.Process git = new System.Diagnostics.Process();
                    string cmnd = string.Format(@"{0}\{1}\{2}", ProgramFilesx64(), @"Git\bin", "git.exe"); 
                    if (!File.Exists(cmnd))
                        cmnd = string.Format(@"{0}\{1}\{2}", ProgramFilesx86(), @"Git\bin", "git.exe");

                    git.StartInfo.FileName = cmnd;
                    git.StartInfo.Arguments = "pull origin master";
                    try
                    {
                        git.Start();
                        git.WaitForExit();
                    }
                    catch (Exception)
                    {
                        throw new Exception(string.Format("Prublemas al ejecutar GIT [ {0} ]", cmnd));
                    }

                    

                    System.Diagnostics.Process celltracker = new System.Diagnostics.Process();
                    cmnd = string.Format(@"{0}\{1}",path,"CellTrack.exe");
                    celltracker.StartInfo.FileName = cmnd;

                    try
                    {
                        celltracker.Start();
                    }
                    catch (Exception)
                    {
                        throw new Exception(string.Format("Prublemas al ejecutar CELLTRACKER [ {0} ]",cmnd));
                    }
                }
            }
            catch (Exception ex)
            {
                ShowWindow(handle, SW_SHOW);
                Console.WriteLine("Problemas al lanzar el LAUNCHER del CELLTRACKER, favor de ponerse en contacto con el administrador del sistema [ {0} ]",ex.Message);
                Console.ReadKey();
            }
            
        }

        static string ProgramFilesx86()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
        }

        static string ProgramFilesx64()
        {
            return @"c:\Program Files";

            return Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
        }
    }
}
