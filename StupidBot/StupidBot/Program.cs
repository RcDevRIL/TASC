using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using log4net.Config;

[assembly: XmlConfigurator(ConfigFile = "log4net.xml", Watch = true)]
namespace StupidBot
{
    public static class Log
    {
        public static ILog StupidLogger
        {
            get { return LogManager.GetLogger("StupidLogger"); }
        }
    }
        static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}
