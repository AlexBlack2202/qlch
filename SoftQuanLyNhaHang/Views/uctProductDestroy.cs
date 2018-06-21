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
    public partial class uctProductDestroy : UserControl
    {

        public uctProductDestroy()
        {
            InitializeComponent();



        }

        public void CreateInputVoucher()
        {


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

            long outputvoucherid = new Controllers.ProductDAO().OutputVoucherAdd(1, 2); //Xuất huỷ tại siêu thị

            if (outputvoucherid < 0)
            {
                MessageBox.Show("Có lỗi trong quá kết nối dữ liệu để tạo phiếu nhập. Vui lòng tắt app mở lại hoặc liên hệ it.");
            }
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



            long inputvoucerdetailid = new Controllers.ProductDAO().OutputVoucherDetailAdd(productid, outputvoucherid, quantity, retailprice);

            if (inputvoucerdetailid < 0)
            {
                MessageBox.Show("Có lỗi trong quá kết nối dữ liệu để tạo phiếu nhập. Vui lòng tắt app mở lại hoặc liên hệ it.");
                return;
            }
            else
            {
                MessageBox.Show("Xuất huỷ thành công.");
            }

            textBoxBarCode.Text = "";
            textBoxQuantity.Text = "0";
            
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

        Models.ProductBO objCurProduct = null;
        private void textBoxBarCode_TextChanged(object sender, EventArgs e)
        {
            string strBarCode = textBoxBarCode.Text;

            if (!string.IsNullOrEmpty(strBarCode) && strBarCode.Length > 3)
            {
                ProductBO objProductBO = new ProductDAO().getproductbybarcode(strBarCode);

                if (objProductBO != null)
                {
                    labelProductName.Text = objProductBO.ProductName;
                    objCurProduct = objProductBO;
                }
                else
                {
                    labelProductName.Text = "";
                    objCurProduct = null;
                }
            }
            else
            {
                labelProductName.Text = "";
                objCurProduct = null;
            }
        }
    }
}
