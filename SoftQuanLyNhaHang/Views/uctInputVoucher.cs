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
using SoftQuanLyNhaHang.Models;
using SoftQuanLyNhaHang.Controllers;

namespace SoftQuanLyNhaHang.Views
{
    public partial class uctInputVoucher : UserControl
    {
        // long inputvoucerid = -1;
        public uctInputVoucher()
        {
            InitializeComponent();



        }

        public void CreateInputVoucher()
        {
            //inputvoucerid = new Controllers.ProductDAO().InputVoucherAdd(1, 1);

            //if (inputvoucerid < 0)
            //{
            //    MessageBox.Show("Có lỗi trong quá kết nối dữ liệu để tạo phiếu nhập. Vui lòng tắt app mở lại hoặc liên hệ it.");
            //}

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

        int stt = 1;

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

            if (quantity <= 0)
            {
                MessageBox.Show("Số lượng nhập phải lớn hơn 0");
                return;
            }

            if (!double.TryParse(textBoxRetailPrice.Text, out retailprice))
            {
                MessageBox.Show("Đơn giá nhập không hợp lệ");
                return;
            }

            //dgvProductList.Rows.Add(stt, textBoxBarCode.Text, labelProductName.Text, textBoxQuantity.Text, textBoxRetailPrice.Text, quantity * retailprice);
            stt++;

            textBoxQuantity.Text = "0";
            textBoxRetailPrice.Text = "1";
            textBoxBarCode.Text = "";
            //long inputvoucerdetailid = new Controllers.ProductDAO().InputVoucherDetailAdd(productid, inputvoucerid, quantity, retailprice);

            //if (inputvoucerdetailid < 0)
            //{
            //    MessageBox.Show("Có lỗi trong quá kết nối dữ liệu để tạo phiếu nhập. Vui lòng tắt app mở lại hoặc liên hệ it.");
            //}
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

        private void textBoxBarCode_TextChanged(object sender, EventArgs e)
        {
            string strBarCode = textBoxBarCode.Text;

            if (!string.IsNullOrEmpty(strBarCode))
            {
                ProductBO objProductBO = new ProductDAO().getproductbybarcode(strBarCode);

                if (objProductBO != null)
                {
                    //labelProductName.Text = objProductBO.ProductName;
                }
                else
                {
                    //labelProductName.Text = "";
                }
            }
            else
            {
                //labelProductName.Text = "";
            }
        }



        private void buttonAddToDataBase_Click(object sender, EventArgs e)
        {
            ProductDAO productDAO = new ProductDAO();
            long inputvoucherid = productDAO.InputVoucherAdd(1, 1);
            if (inputvoucherid == -1)
            {
                MessageBox.Show("Không thể tạo phiếu xuất. Liên hệ it");
                return;
            }
            DataTable dt = new DataTable();
            dt = Utils.Utils.GetDataTableFromDGV(dgvProductList);

            bool result = productDAO.InputVoucherDetailAdd(dt, inputvoucherid);

            if (!result)
            {
                MessageBox.Show("Không thể tạo phiếu xuất. Liên hệ it để biết chi tiết");
                return;
            }

            else
            {
                MessageBox.Show("Tạo phiếu xuất thành công");

            }

            dgvProductList.Rows.Clear();
            stt = 1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
