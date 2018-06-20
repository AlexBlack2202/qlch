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
    public partial class uctInputVoucher : UserControl
    {
        long inputvoucerid = -1;
        public uctInputVoucher()
        {
            InitializeComponent();
            CreateInputVoucher();


        }

        public void CreateInputVoucher()
        {
            inputvoucerid = new Controllers.ProductDAO().InputVoucherAdd(1,1);

            if (inputvoucerid < 0)
            {
                MessageBox.Show("Có lỗi trong quá kết nối dữ liệu để tạo phiếu nhập. Vui lòng tắt app mở lại hoặc liên hệ it.");
            }

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



        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            string productid = "";
            double quantity = 0;
            double retailprice = 0;

            if (string.IsNullOrEmpty(textBoxBarCode.Text))
            {
                MessageBox.Show("Mã sản phẩm không đúng");
                return;
            }

            productid = textBoxBarCode.Text.Trim();

            if (!double.TryParse(textBoxQuantity.Text, out quantity))
            {
                MessageBox.Show("Số lượng nhập không hợp lệ");
                return;
            }

            if (!double.TryParse(textBoxRetailPrice.Text, out retailprice))
            {
                MessageBox.Show("Đơn giá nhập không hợp lệ");
                return;
            }

            long inputvoucerdetailid = new Controllers.ProductDAO().InputVoucherDetailAdd(productid, inputvoucerid, quantity, retailprice);

            if (inputvoucerdetailid < 0)
            {
                MessageBox.Show("Có lỗi trong quá kết nối dữ liệu để tạo phiếu nhập. Vui lòng tắt app mở lại hoặc liên hệ it.");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            uctNhanVien_Load(sender, e);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void dgvDanhSachNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
