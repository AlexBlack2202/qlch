using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftQuanLyNhaHang.Views
{
    public partial class FormInputVoucher : Form
    {
        public FormInputVoucher()
        {
            InitializeComponent();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePickerDate.Value.Date;

            DataTable dataTable = new Controllers.ProductDAO().GetReportInputByDate(dateTime);

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                try
                {
                    var newFile = new FileInfo("Report/Input_" + dateTime.ToString("yyyyMMdd") + ".xlsx");
                    using (ExcelPackage pck = new ExcelPackage(newFile))
                    {
                        ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Accounts");
                        ws.Cells["A1"].LoadFromDataTable(dataTable, true);
                        pck.Save();
                    }

                    MessageBox.Show("Xuất file thành công");
                }
                catch { }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất file.");
            }
        }
    }
}
