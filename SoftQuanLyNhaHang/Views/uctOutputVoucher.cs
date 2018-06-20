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
    public partial class uctOutputVoucher : UserControl
    {
        public uctOutputVoucher()
        {
            InitializeComponent();
        }
        private void uctBan_Load(object sender, EventArgs e)
        {
        }

        void loadcontrol()
        {


        }

        int stt = 1;

        double dbTotalBillModey = 0;
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            double dbQuantity = 0;

            if (string.IsNullOrEmpty(textBoxSoLuong.Text) || !double.TryParse(textBoxSoLuong.Text, out dbQuantity))
            {
                MessageBox.Show("Số lượng nhập không đúng");
                return;
            }

            dbTotalBillModey += curProductBO.SellPrice * dbQuantity;

            labelReturnMoney.Text = dbTotalBillModey.ToString();
            dgvDanhSachSanPham.Rows.Add(stt, curProductBO.ProductName, dbQuantity, curProductBO.SellPrice, curProductBO.ProductID);

            stt++;

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        ProductBO curProductBO = null;
        private void txtIdBan_TextChanged(object sender, EventArgs e)
        {
            string strBarCode = textBoxBarCode.Text;

            if (!string.IsNullOrEmpty(strBarCode))
            {
                ProductBO objProductBO = new ProductDAO().getproductbybarcode(strBarCode);

                if (objProductBO != null)
                {
                    labelProductName.Text = objProductBO.ProductName;
                    curProductBO = objProductBO;
                }
            }
        }

        private void textBoxCustomerMoney_TextChanged(object sender, EventArgs e)
        {
            double dbCurMoney = double.Parse(textBoxCustomerMoney.Text);

            double dbTotalModey = double.Parse(labelTotal.Text);

            double dbReturn = dbCurMoney - dbTotalModey;
            labelReturnMoney.Text = dbReturn.ToString();
        }

        private void textBoxCustomerMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonPrintInvoice_Click(object sender, EventArgs e)
        {
            ProductDAO productDAO = new ProductDAO();
            long inputvoucherid = productDAO.InputVoucherAdd(1, 1);
            if (inputvoucherid == -1)
            {
                MessageBox.Show("Không thể tạo phiếu xuất. Liên hệ it");
                return;
            }
            DataTable dt = new DataTable();
            dt = (DataTable)dgvDanhSachSanPham.DataSource;

            bool result = productDAO.InputVoucherDetailAdd(dt, inputvoucherid);

            if (!result)
            {
                MessageBox.Show("Không thể tạo phiếu xuất. Liên hệ it để biết chi tiết");
                return;
            }

            else
            {
                MessageBox.Show("Tạo phiếu xuất thành công");
                return;
            }
        }
    }
}
