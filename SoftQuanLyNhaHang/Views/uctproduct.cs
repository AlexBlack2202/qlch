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
using SoftQuanLyNhaHang.Controllers;
using SoftQuanLyNhaHang.Models;

namespace SoftQuanLyNhaHang.Views
{
    public partial class uctproduct : UserControl
    {
        public uctproduct()
        {
            InitializeComponent();
        }
        public static uctproduct uctProductBO = new uctproduct();
        int flag = 0;

        // Resize the master DataGridView columns to fit the newly loaded data. masterDataGridView.AutoResizeColumns();
        // Configure the details DataGridView so that its columns automatically 
        // adjust their widths when the data changes.
        //private void SizeAllColumns(Object sender, EventArgs e)
        //{
        //    dgvDanhSachNV.AutoResizeColumns(
        //        DataGridViewAutoSizeColumnsMode.AllCells);
        //    dgvDanhSachNV.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);

        //}
        private void uctproduct_Load(object sender, EventArgs e)
        {

        }


        //private void dgvDanhSachNV_Click(object sender, EventArgs e)
        //{
        //    DataSet ds = new DataSet();
        //    try
        //    {
        //        //int i = 0;
        //        //i = dgvDanhSachNV.CurrentRow.Index;
        //        //string _idHocVien = dgvDanhSachNV.Rows[i].Cells[0].Value.ToString();
        //        //ds = Controllers.NhanVienCtrl.FillDataSet_getNhanVienByIdNhanVien(_idHocVien);
        //        //txtIdNhanVien.DataBindings.Clear();
        //        //txtIdNhanVien.DataBindings.Add("text", ds.Tables[0], "IdNhanVien");
        //        //txtHolotNV.DataBindings.Clear();
        //        //txtHolotNV.DataBindings.Add("text", ds.Tables[0], "HoLot");
        //        //txtTenNV.DataBindings.Clear();
        //        //txtTenNV.DataBindings.Add("text", ds.Tables[0], "Ten");
        //        //dtpNgaySinhNV.DataBindings.Clear();
        //        //dtpNgaySinhNV.DataBindings.Add("text", ds.Tables[0], "Ngaysinh");
        //        //cmbGioiTinhNV.DataBindings.Clear();
        //        //cmbGioiTinhNV.DataBindings.Add("text", ds.Tables[0], "GioiTinh");
        //        //txtDienThoaiNV.DataBindings.Clear();
        //        //txtDienThoaiNV.DataBindings.Add("text", ds.Tables[0], "DienThoai");
        //        //txtEmailNV.DataBindings.Clear();
        //        //txtEmailNV.DataBindings.Add("text", ds.Tables[0], "Email");
        //        //txtDiaChiNV.DataBindings.Clear();
        //        //txtDiaChiNV.DataBindings.Add("text", ds.Tables[0], "DiaChi");

        //    }
        //    catch { }

        //}

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

        }

        private void btnHide_Click(object sender, EventArgs e)
        {

        }


        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            string strBarcode = txtbarcode.Text;
            string strproductname = txproductname.Text;

            double dbSellPrice = -1;
            if (string.IsNullOrEmpty(strBarcode))
            {
                MessageBox.Show("Mã barcode không hợp lệ");
                return;
            }
            if (string.IsNullOrEmpty(textBoxSellPrice.Text) || !double.TryParse(textBoxSellPrice.Text, out dbSellPrice))
            {
                MessageBox.Show("Giá bán không hợp lệ");
                return;
            }

            if (string.IsNullOrEmpty(strproductname))
            {
                MessageBox.Show("Tên sản phẩm không hợp lệ");
                return;
            }

            bool result = new Controllers.ProductDAO().AddProduct(strBarcode, strproductname, dbSellPrice);

            if (!result)
            {
                MessageBox.Show("Có lỗi trong quá trình thêm dữ liệu");
                return;
            }

            txtbarcode.Text = "";
            txproductname.Text = "";

            textBoxSellPrice.Text = "-1";


        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (curProductBO == null)
            {
                MessageBox.Show("Mã sản phẩm hiện tại không hợp lệ");
                return;
            }

            double dbSellPrice = -1;

            if (string.IsNullOrEmpty(textBoxRetailPriceEdit.Text) || !double.TryParse(textBoxRetailPriceEdit.Text, out dbSellPrice))
            {
                MessageBox.Show("Giá bán không hợp lệ");
                return;
            }

            bool result = new Controllers.ProductDAO().UpdateProductSellPrice(curProductBO.ProductID, dbSellPrice);

            if (!result)
            {
                MessageBox.Show("Có lỗi trong quá trình thêm dữ liệu");
                return;
            }

            textBoxProductIDEditPrice.Text = "";
            labelProductNameEdit.Text = "";

            textBoxRetailPriceEdit.Text = "-1";


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void grQuanLyNV_Enter(object sender, EventArgs e)
        {

        }

        ProductBO curProductBO = null;
        private void textBoxProductIDEditPrice_TextChanged(object sender, EventArgs e)
        {
            string strBarCode = textBoxProductIDEditPrice.Text;

            if (!string.IsNullOrEmpty(strBarCode))
            {
                ProductBO objProductBO = new ProductDAO().getproductbybarcode(strBarCode);

                if (objProductBO != null)
                {
                    labelProductNameEdit.Text = objProductBO.ProductName;
                    curProductBO = objProductBO;
                }
            }
        }

        private void labelProductName_Click(object sender, EventArgs e)
        {

        }

        private void txtbarcode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
