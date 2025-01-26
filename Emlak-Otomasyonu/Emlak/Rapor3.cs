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

namespace Emlak
{
    public partial class Rapor3 : Form
    {
        public Rapor3()
        {
            InitializeComponent();
        }

        private void Rapor3_Load(object sender, EventArgs e)
        {

            emlakDBEntities vt = new emlakDBEntities();
            List<SatilikEv> satilikEv = vt.SatilikEvs.ToList();
            reportViewer3.RefreshReport();
            reportViewer3.LocalReport.DataSources.Clear();
            reportViewer3.LocalReport.ReportEmbeddedResource = "Emlak.Report3.rdlc";
            ReportDataSource dataset = new ReportDataSource("DataSet1", satilikEv);
            reportViewer3.LocalReport.DataSources.Add(dataset);
            reportViewer3.LocalReport.Refresh();
            reportViewer3.RefreshReport();
        }
    }
}
