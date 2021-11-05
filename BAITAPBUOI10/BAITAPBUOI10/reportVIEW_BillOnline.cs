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
    public partial class reportVIEW_BillOnline : Form
    {
        public reportVIEW_BillOnline()
        {
            InitializeComponent();
        }

        private void reportVIEW_BillOnline_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
        public void LoadReport(DataTable dt)
        {
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "../../Report_BillOnline.rdlc";

            ReportDataSource dts = new ReportDataSource();
            dts.Name = "DataSet1_reportBillOnline";
            dts.Value = dt;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(dts);
        
           
        }

    }
}
