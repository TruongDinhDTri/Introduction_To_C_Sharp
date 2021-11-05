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
    public partial class reportVIEW_BillKidPlaza : Form
    {
        public reportVIEW_BillKidPlaza()
        {
            InitializeComponent();
        }

        private void reportVIEW_BillKidPlaza_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        public void LoadReport(DataTable dt, string TenKH,string TenNV,string SoKM)
        {
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "../../Report_BillKidPlaza.rdlc";

            ReportDataSource dts = new ReportDataSource();
            dts.Name = "DataSet1_reportBillKidPlaza";
            dts.Value = dt;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(dts);
            ReportParameter para1 = new ReportParameter();
            ReportParameter para2 = new ReportParameter();
            ReportParameter para3 = new ReportParameter();
            para1.Name = "TenKH";
            para2.Name = "TenNV";
            para3.Name = "SoKM1";
            para1.Values.Add(TenKH);
            para2.Values.Add(TenNV);
            para3.Values.Add(SoKM);
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { para1,para2,para3 });
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
