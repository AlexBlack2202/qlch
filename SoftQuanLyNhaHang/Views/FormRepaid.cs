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
    public partial class FormRepaid : Form
    {
        public DataTable dataTable = new DataTable();
        public long inputvoucherid;
        public double total;
        public FormRepaid()
        {
            InitializeComponent();
        }

        private void FormRepaid_Load(object sender, EventArgs e)
        {
            List<Models.InputVoucherDetailBO> lstdata = dataTable.ToList<Models.InputVoucherDetailBO>();

            foreach (var item in lstdata)
            {
                item.ProductName = item.ProductName.NonUnicode();
            }
            crystalReportRepaid.SetDataSource(lstdata);
            
            crystalReportRepaid.SetParameterValue("pinputvoucherid", inputvoucherid);
            crystalReportRepaid.SetParameterValue("pdate", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            crystalReportRepaid.SetParameterValue("ptotal", total);
            crystalReportViewer.ReportSource = crystalReportRepaid;
        }
    }
}
