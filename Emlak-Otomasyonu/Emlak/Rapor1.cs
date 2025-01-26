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
    public partial class Rapor1 : Form
    {
        public Rapor1()
        {
            InitializeComponent();
        }

        private void Rapor1_Load(object sender, EventArgs e)
        {

            emlakDBEntities vt = new emlakDBEntities();
            List<Ev> evListesi = vt.Evs.ToList();
            reportViewer1.RefreshReport();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Emlak.Report1.rdlc";
            ReportDataSource dataset = new ReportDataSource("DataSet1", evListesi);
            reportViewer1.LocalReport.DataSources.Add(dataset);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
