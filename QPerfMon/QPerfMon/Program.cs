using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace QPerfMon
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (Properties.Settings.Default.NewVersion)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.NewVersion = false;
                Properties.Settings.Default.Save();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                var title = "QPerfMon";
                MainForm m;
                if (args.Length == 0)
                {
                    m = new MainForm(new string[] { @"<xml><machine>.</machine><category>Processor</category><counter>% Processor Time</counter><instance>_Total</instance><scale>1</scale><color>red</color></xml>" });
                }
                else
                {
                    var fi = new FileInfo(args[0]);
                    m = new MainForm(args);
                    title += " - " + fi.Name;
                }
                //m.Text = title;
                m.defaultTitle = title;
                Application.Run(m);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
