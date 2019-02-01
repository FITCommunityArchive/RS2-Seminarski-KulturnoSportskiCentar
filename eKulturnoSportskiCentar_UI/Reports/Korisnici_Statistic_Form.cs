using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eKulturnoSportskiCentar_API.Models;
using Microsoft.Reporting.WinForms;

namespace eKulturnoSportskiCentar_UI.Reports
{
    public partial class Korisnici_Statistic_Form : Form
    {
        public List<Korisnici_Result> lista = new List<Korisnici_Result>();
        public Korisnici_Statistic_Form()
        {
            InitializeComponent();
        }

        private void Korisnici_Statistic_Form_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("dbKorisniciStatistic", lista);
            this.reportViewer1.LocalReport.DataSources.Add(rds); 
            this.reportViewer1.RefreshReport();
        }
    }
}
