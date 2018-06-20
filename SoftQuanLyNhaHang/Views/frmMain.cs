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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        internal static List<byte> typePages = new List<byte>();
        public void ThemTabPages(UserControl uct, byte typeControl, string tenTab)
        {
            // Kiểm tra tồn tại trang này chưa
            for (int i = 0; i < TabHienThi.TabPages.Count; i++)
            {
                if (TabHienThi.TabPages[i].Contains(uct) == true)
                {
                    TabHienThi.SelectedTab = TabHienThi.TabPages[i];
                    return;
                }
            }
            TabPage tab = new TabPage();
            typePages.Add(typeControl);
            tab.Name = uct.Name;
            tab.Size = TabHienThi.Size;
            tab.Text = tenTab;
            TabHienThi.TabPages.Add(tab);
            TabHienThi.SelectedTab = tab;
            uct.Dock = DockStyle.Fill;
            tab.Controls.Add(uct);
            uct.Focus();

        }
        public void DongTabHienTai()
        {
            TabHienThi.TabPages.Remove(TabHienThi.SelectedTab);
        }
        public void DongAllTab()
        {
            while (TabHienThi.TabPages.Count > 0)
            {
                DongTabHienTai();
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýNhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.uctNhanVien.uctNV, 4, "Quản lý nhân viên ");
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.uctKhachHang.uctKH, 4, "Quản lý  khách hàng");
        }

        private void menuItemDongTrang_Click(object sender, EventArgs e)
        {
            DongTabHienTai();
        }

        private void menuItemDongTrangAll_Click(object sender, EventArgs e)
        {
            DongAllTab();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
                return;
        }

        private void lựaChọnKhuVựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.uctBan.uctban, 4, "Quản lý bàn");
        }
        private void hệThốngKhuVựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.uctKhuVuc.uctKV, 4, "Hệ thống khu vực");
        }

        private void mónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.uctLoaiThucDon.uctLTD, 4, "Loại thực đơn");
        }


        private void thứcUốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.uctThucDon.uctTD, 4, "Danh sách thực đơn");
        }

        private void gọiMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ThemTabPages(Views.uctGoiMon.uctGM, 4, "Danh mục gọi món ");
            ThemTabPages(new Views.uctOutputVoucher(), 4, "Bán hàng");
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ThemTabPages(Views.uctHoaDon.uctHD, 4, "Hóa đơn");
        }

        private void phânQuyềnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.uctPhanQuyen.uctPQ, 4, "Phân quyền sử dụng ");
        }

        private void ctxtmenuTabBan_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void DeclareProductToolTip_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.uctproduct.uctProductBO, 4, "Khai báo sản phẩm");
        }

        private void InputVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(new Views.uctInputVoucher(), 4, "Nhập kho");
        }

        private void xuathuysanphamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(new Views.uctProductDestroy(), 4, "Xuất huỷ");
        }

        private void customerrepaidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(new Views.uctCustomerRepaid(), 4, "Khách trả hàng");
        }

        private void InventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new Controllers.ProductDAO().GetInventory();

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                try
                {
                    var newFile = new FileInfo("Inventory_" + DateTime.Now.ToString("yyyyMMdd") + ".xlsx");
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
