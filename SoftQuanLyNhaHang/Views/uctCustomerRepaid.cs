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
    public partial class uctCustomerRepaid : UserControl
    {
        // long inputvoucerid = -1;
        public uctCustomerRepaid()
        {
            InitializeComponent();
            //  CreateInputVoucher();


        }

        public void CreateInputVoucher()
        {
            //inputvoucerid = new Controllers.ProductDAO().InputVoucherAdd();

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

        int intStep = 1;

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            string productid = "";
            double quantity = 0;
            double retailprice = 0;

            string outputid = "";

            if (string.IsNullOrEmpty(outputid))
            {
                MessageBox.Show("Mã đơn hàng không đúng");
                return;
            }

            if (lstOutputVoucer == null)
            {
                MessageBox.Show("Mã đơn hàng không có trên hệ thống");
                return;
            }

            if (string.IsNullOrEmpty(textBoxBarCode.Text))
            {
                MessageBox.Show("Mã sản phẩm không đúng");
                return;
            }

            if (objCurProduct == null)
            {
                MessageBox.Show("Mã sản phẩm không có trên hệ thống");
                return;
            }

            productid = textBoxBarCode.Text.Trim();

            if (!double.TryParse(textBoxQuantity.Text, out quantity))
            {
                MessageBox.Show("Số lượng nhập không hợp lệ");
                return;
            }



            OutputVoucherDetail curOutput = lstOutputVoucer.FirstOrDefault(p => p.ProductID == productid);

            if (curOutput == null)
            {
                MessageBox.Show("Đơn hàng trên không có sản phẩm này.");
                return;
            }

            dgvProductList.Rows.Add(intStep, objCurProduct.ProductName, quantity, curOutput.SalePrice, productid, outputid);
        }

        ProductBO objCurProduct = null;

        List<OutputVoucherDetail> lstOutputVoucer = null;
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

        private void textBoxOutputVoucherID_TextChanged(object sender, EventArgs e)
        {
            string curText = textBoxOutputVoucherID.Text;

            if (curText != null && curText.Length > 5)
            {
                long outputvoucherid = long.Parse(curText);
                lstOutputVoucer = new Controllers.ProductDAO().getlistoutputvoucherdetail(outputvoucherid);
            }
            else
            {
                lstOutputVoucer = null;
            }
        }

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

        private void buttonCustomerRepaid_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = (DataTable)dgvProductList.DataSource;


            if (dt != null && dt.Rows.Count > 0)
            {

                long inputvoucerid = new Controllers.ProductDAO().InputVoucherAdd(1, 2);

                if (inputvoucerid < 0)
                {
                    MessageBox.Show("Có lỗi trong quá kết nối dữ liệu để tạo phiếu nhập. Vui lòng tắt app mở lại hoặc liên hệ it.");
                    return;
                }


                
            }

        }

        private void grQuanLyNV_Enter(object sender, EventArgs e)
        {

        }
    }
}
