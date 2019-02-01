using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using eKulturnoSportskiCentar_UI.Dogadjaj_UI;
using eKulturnoSportskiCentar_UI.Korisnik_UI;
using eKulturnoSportskiCentar_UI.Reports;
using eKulturnoSportskiCentar_UI.Termin_UI;

namespace eKulturnoSportskiCentar_UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
      
           
            Login login = new Login();
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }

        }
    }
}
