using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

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
            /* Debug */
            if (true)//args.Length == 0)
            {
                args = new string[] { @"C:\Users\Tjark\Dropbox\Bezirksjugendtreffen 2012\Abendprogramm\runde1.jg", "Foo", "Bar", "Baz" };
            }
            /* */
            // Um Konsolenausgabe kuemmern
            AttachConsole(ATTACH_PARENT_PROCESS);
            /* */
            if (args.Length != 1 && args.Length != 4)
            {
                Console.WriteLine("\nUsage: jeopardy.exe JEOPARDYGAMEFILE.jd [player1 player2 player3]\n");
                return 1;
            }
            if (!File.Exists(args[0]))
            {
                Console.WriteLine("\n\"" + args[0] + "\" existiert nicht.\nUsage: jeopardy.exe JEOPARDYGAMEFILE.jd\n");
                return 1;
            }
            /* */
            Console.WriteLine("\n");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length == 1)
            {
                Application.Run(new MainForm(args[0]));
            }
            else
            {
                Application.Run(new MainForm(args[0], args[1], args[2], args[3]));
            }
//            Application.Run(new MainForm("C:\\Users\\Tjark\\Dropbox\\Bezirksjugendtreffen 2012\\Abendprogramm\\runde1_.jg"));
            return 0;
        }
    }
}
