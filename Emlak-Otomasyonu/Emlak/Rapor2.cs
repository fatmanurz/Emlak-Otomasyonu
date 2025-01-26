using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emlak
{
    public partial class Rapor2 : Form
    {
        public Rapor2()
        {
            InitializeComponent();
        }

        private void Rapor2_Load(object sender, EventArgs e)
        {
            emlakDBEntities vt = new emlakDBEntities();
            List<KiralikEv> kiralikevListesi = vt.KiralikEvs.ToList();
            reportViewer2.RefreshReport();
            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.ReportEmbeddedResource = "Emlak.Report2.rdlc";
            ReportDataSource dataset = new ReportDataSource("DataSet1", kiralikevListesi);
            reportViewer2.LocalReport.DataSources.Add(dataset);
            reportViewer2.LocalReport.Refresh();
            reportViewer2.RefreshReport();
            this.reportViewer2.RefreshReport();
        }
    }
}
