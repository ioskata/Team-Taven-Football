using System;
using System.Collections.Generic;
using System.Linq;
namespace TeamTavenFootball
{
    using System.Threading.Tasks;
    using System.Windows.Forms;

    static class StartingPoint
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FootballEngine());
        }
    }
}
