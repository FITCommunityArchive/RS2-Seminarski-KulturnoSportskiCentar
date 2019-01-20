using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKulturnoSportskiCentar_UI.Dogadjaj_UI
{
    public partial class IndexDogadjaj : Form
    {
        public IndexDogadjaj()
        {
            InitializeComponent();
        }

        private void Administracija_BTN_Click(object sender, EventArgs e)
        {
            Close();
            AdministracijaDogadjaja f = new AdministracijaDogadjaja();
            f.ShowDialog();
        }

        private void Javni_BTN_Click(object sender, EventArgs e)
        {
            Close();
            JavniDogadjaji f = new JavniDogadjaji();
            f.ShowDialog();
        }

        private void Vlastiti_BTN_Click(object sender, EventArgs e)
        {
            Close();
            VlastitiDogadjaji f=new VlastitiDogadjaji();
            f.ShowDialog();
        }

        private void GoingEvents_Click(object sender, EventArgs e)
        {
            Dogadjaji_za_posjetiti f=new Dogadjaji_za_posjetiti();
            Close();
            f.ShowDialog();
        }
    }
}
