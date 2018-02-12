using AutoAccepter.Properties;
using System;
using System.Diagnostics;
using System.IO;

namespace AutoAccepter
{
    public static class MatchAccepter
    {
        private static string file_exe = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\keystroke_simulator.exe";

        public static void Accept()
        {
            FileStream fs = new FileStream(file_exe, FileMode.Create);
            fs.Write(Resources.keystroke_simulator, 0, Resources.keystroke_simulator.Length);
            fs.Close();
            Process.Start(file_exe);
            ProcessStartInfo kssi = new ProcessStartInfo(file_exe);
            Process kss = Process.Start(kssi);
            kss.WaitForExit(3000);
        }
    }
}
