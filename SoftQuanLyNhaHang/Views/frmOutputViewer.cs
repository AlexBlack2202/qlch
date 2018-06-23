using SoftQuanLyNhaHang.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftQuanLyNhaHang.Views
{
    public partial class frmOutputViewer : Form
    {
        public DataTable dataTable = new DataTable();
        public long outputvoucherid;
        public double total;
        public frmOutputViewer()
        {
            InitializeComponent();


        }

        private void frmOutputViewer_Load(object sender, EventArgs e)
        {
            List<Models.OutputVoucherDetailBO> lstdata = dataTable.ToList<Models.OutputVoucherDetailBO>();

            foreach (var item in lstdata)
            {
                item.ProductName = item.ProductName.NonUnicode();
            }
            crystalReportOutput1.SetDataSource(lstdata);

            crystalReportOutput1.SetParameterValue("poutputid", outputvoucherid);
            crystalReportOutput1.SetParameterValue("pdate", DateTime.Now.ToString("dd/MM/yyyy"));
            crystalReportOutput1.SetParameterValue("ptotal", total);
            crystalReportViewer.ReportSource = crystalReportOutput1;
        }
    }
}
