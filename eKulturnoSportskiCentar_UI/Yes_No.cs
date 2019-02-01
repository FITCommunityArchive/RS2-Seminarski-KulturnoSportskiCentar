using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKulturnoSportskiCentar_UI
{
    public partial class Yes_No : Form
    {
        private int id { get; set; }
        public Yes_No(string poruka)
        {
            InitializeComponent();
            label1.Text = poruka;
            label1.AutoSize = true;
        }

        private void Ne_BTN_Click(object sender, EventArgs e)
        {
            Close();
            DialogResult = DialogResult.No;
        }

        private void Da_BTN_Click(object sender, EventArgs e)
        {
            Close();
            DialogResult = DialogResult.Yes;
        }
    }
}
