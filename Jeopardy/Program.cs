using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Jeopardy
{
    static class Program
    {
        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);
        private const int ATTACH_PARENT_PROCESS = -1;

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static int Main(string[] args)
        {
            // Um Konsolenausgabe kuemmern
            AttachConsole(ATTACH_PARENT_PROCESS);
            /*
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: jeopardy.exe JEOPARDYGAMEFILE.jd");
                return 1;
            }
             */
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
//            Application.Run(new Form1(args[0]));
            Application.Run(new Form1("D:\\Users\\Tjark\\Dropbox\\Bezirksjugendtreffen 2012\\Abendprogramm\\runde1_.jg"));
            return 0;
        }
    }
}
