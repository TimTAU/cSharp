using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Datei befüllen, bevor die UI geladen wird
            FillFile();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static void FillFile()
        {
            ArrayList textList = new ArrayList
            {
                "Dies ist eine Zeile",
                "Und hier gibt es sogar noch eine",
                "Das ist alles so wunderschöner Text",
                "Und der geht noch viel weiter"
            };

            StreamWriter writer = new StreamWriter("../../text.txt");
            using (writer)
            {
                foreach (var line in textList)
                {
                    writer.WriteLine(line);
                }
            }
        }
    }
}