using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SoftQuanLyNhaHang.Views
{
    public partial class uctNhanVien : UserControl 
    {
        public uctNhanVien()
        {
            InitializeComponent();
        }
        public static uctNhanVien uctNV = new uctNhanVien();
        int flag = 0;
        public void HienThiDanhSachNhanVien()
        {
            dgvDanhSachNV.DataSource = Models.NhanVienMod.FillDataSetNhanVien().Tables[0];
            dgvDanhSachNV.Dock = DockStyle.Fill;
            dgvDanhSachNV.RowHeadersVisible = false;
            dgvDanhSachNV.BorderStyle = BorderStyle.Fixed3D;
        }
        // Resize the master DataGridView columns to fit the newly loaded data. masterDataGridView.AutoResizeColumns();
        // Configure the details DataGridView so that its columns automatically 
        // adjust their widths when the data changes.
        //private void SizeAllColumns(Object sender, EventArgs e)
        //{
        //    dgvDanhSachNV.AutoResizeColumns(
        //        DataGridViewAutoSizeColumnsMode.AllCells);
        //    dgvDanhSachNV.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);

        //}
        private void uctNhanVien_Load(object sender, EventArgs e)
        {
        }
        public void nhung(Control ctr)
        {
            pnlDanhSachNV.Controls.Clear();
            pnlDanhSachNV.BorderStyle = BorderStyle.Fixed3D;
            ctr.Dock = DockStyle.Fill;
            pnlDanhSachNV.Controls.Add(ctr);
            pnlDanhSachNV.Show();
        }
        void loadcontrol()
        {
          
        }
       
        private void txtDienThoaiNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            uctSearchNhanVien uctS = new uctSearchNhanVien();
            nhung(uctS);
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            pnlDanhSachNV.Controls.Clear();
            pnlDanhSachNV.BorderStyle = BorderStyle.None;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
           
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
          
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
        }


    }
}
