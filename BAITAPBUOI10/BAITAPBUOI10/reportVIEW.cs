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

namespace BAITAPBUOI10
{
    public partial class reportVIEW : Form
    {
        public reportVIEW()
        {
            InitializeComponent();
        }

        private void reportVIEW_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
        public void LoadReport(DataTable dt, string TenKH)
        {
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "../../Report1.rdlc";

            ReportDataSource dts = new ReportDataSource();
            dts.Name = "DataSet1_reportBill";
            dts.Value = dt;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(dts);
            ReportParameter para1 = new ReportParameter();
            para1.Name = "TenKH";
            para1.Values.Add(TenKH);
           
            reportViewer1.LocalReport.SetParameters(new ReportParameter[]  { para1 });
        }
    }
}
