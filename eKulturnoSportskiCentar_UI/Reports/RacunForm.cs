using eKulturnoSportskiCentar_API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace eKulturnoSportskiCentar_UI.Reports
{
    public partial class RacunForm : Form
    {
        //public List<Dogadjaj_Detalji_Result> Dogadjaji { get; set; }
        public DateTime Datum { get; set; }
        public string sala { get; set; }
        public string korisnik { get; set; }
        public string satnica { get; set; }
        public string dogadjaj{ get; set; }

        public double cijenaDodatneOpreme { get; set; }
        public double ukupnaCijena { get; set; }

        public string vrstaDogadjaja { get; set; }
        public List<DodatnaOprema> DodatnaOprema =
            new List<DodatnaOprema>();
        public RacunForm()
        {
            InitializeComponent();
        }

        private void RacunForm_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("DataSet1", DodatnaOprema);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Sala", sala));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Datum", Datum.ToString("dd.MM.yyyy")));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Korisnik",korisnik));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Satnica", satnica));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Dogadjaj", dogadjaj));

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("CijenaDodatneOpreme", cijenaDodatneOpreme.ToString()));

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("VrstaDogadjaja", vrstaDogadjaja));
            this.reportViewer1.RefreshReport();
          
        }
    }
}
