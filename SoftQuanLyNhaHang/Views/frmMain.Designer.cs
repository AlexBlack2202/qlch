namespace SoftQuanLyNhaHang.Views
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.TabHienThi = new System.Windows.Forms.TabControl();
            this.ctxtmenuTabHienThi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemDongTrang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDongTrangAll = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeclareProductToolTip = new System.Windows.Forms.ToolStripMenuItem();
            this.InputVoucherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuathuysanphamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerrepaidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gọiMónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxtmenuTabBan = new System.Windows.Forms.MenuStrip();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxtmenuTabHienThi.SuspendLayout();
            this.ctxtmenuTabBan.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabHienThi
            // 
            this.TabHienThi.ContextMenuStrip = this.ctxtmenuTabHienThi;
            this.TabHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabHienThi.Location = new System.Drawing.Point(0, 35);
            this.TabHienThi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabHienThi.Name = "TabHienThi";
            this.TabHienThi.SelectedIndex = 0;
            this.TabHienThi.Size = new System.Drawing.Size(1542, 1015);
            this.TabHienThi.TabIndex = 1;
            // 
            // ctxtmenuTabHienThi
            // 
            this.ctxtmenuTabHienThi.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ctxtmenuTabHienThi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDongTrang,
            this.menuItemDongTrangAll});
            this.ctxtmenuTabHienThi.Name = "ctxtmenuTabHienThi";
            this.ctxtmenuTabHienThi.Size = new System.Drawing.Size(239, 64);
            // 
            // menuItemDongTrang
            // 
            this.menuItemDongTrang.Name = "menuItemDongTrang";
            this.menuItemDongTrang.Size = new System.Drawing.Size(238, 30);
            this.menuItemDongTrang.Text = "Đóng trang hiện tại";
            this.menuItemDongTrang.Click += new System.EventHandler(this.menuItemDongTrang_Click);
            // 
            // menuItemDongTrangAll
            // 
            this.menuItemDongTrangAll.Name = "menuItemDongTrangAll";
            this.menuItemDongTrangAll.Size = new System.Drawing.Size(238, 30);
            this.menuItemDongTrangAll.Text = "Đóng tất cả";
            this.menuItemDongTrangAll.Click += new System.EventHandler(this.menuItemDongTrangAll_Click);
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeclareProductToolTip,
            this.InputVoucherToolStripMenuItem,
            this.xuathuysanphamToolStripMenuItem,
            this.customerrepaidToolStripMenuItem});
            this.quảnLýNhânViênToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýNhânViênToolStripMenuItem.Image")));
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(114, 29);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý ";
            // 
            // DeclareProductToolTip
            // 
            this.DeclareProductToolTip.Name = "DeclareProductToolTip";
            this.DeclareProductToolTip.Size = new System.Drawing.Size(259, 30);
            this.DeclareProductToolTip.Text = "Khai báo sản phẩm";
            this.DeclareProductToolTip.Click += new System.EventHandler(this.DeclareProductToolTip_Click);
            // 
            // InputVoucherToolStripMenuItem
            // 
            this.InputVoucherToolStripMenuItem.Name = "InputVoucherToolStripMenuItem";
            this.InputVoucherToolStripMenuItem.Size = new System.Drawing.Size(259, 30);
            this.InputVoucherToolStripMenuItem.Text = "Nhập kho";
            this.InputVoucherToolStripMenuItem.Click += new System.EventHandler(this.InputVoucherToolStripMenuItem_Click);
            // 
            // xuathuysanphamToolStripMenuItem
            // 
            this.xuathuysanphamToolStripMenuItem.Name = "xuathuysanphamToolStripMenuItem";
            this.xuathuysanphamToolStripMenuItem.Size = new System.Drawing.Size(259, 30);
            this.xuathuysanphamToolStripMenuItem.Text = "Xuất huỷ sản phẩm";
            this.xuathuysanphamToolStripMenuItem.Click += new System.EventHandler(this.xuathuysanphamToolStripMenuItem_Click);
            // 
            // customerrepaidToolStripMenuItem
            // 
            this.customerrepaidToolStripMenuItem.Name = "customerrepaidToolStripMenuItem";
            this.customerrepaidToolStripMenuItem.Size = new System.Drawing.Size(259, 30);
            this.customerrepaidToolStripMenuItem.Text = "Khách hàng trả hàng";
            this.customerrepaidToolStripMenuItem.Click += new System.EventHandler(this.customerrepaidToolStripMenuItem_Click);
            // 
            // gọiMónToolStripMenuItem
            // 
            this.gọiMónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gọiMónToolStripMenuItem.Image")));
            this.gọiMónToolStripMenuItem.Name = "gọiMónToolStripMenuItem";
            this.gọiMónToolStripMenuItem.Size = new System.Drawing.Size(122, 29);
            this.gọiMónToolStripMenuItem.Text = "Bán hàng";
            this.gọiMónToolStripMenuItem.Click += new System.EventHandler(this.gọiMónToolStripMenuItem_Click);
            // 
            // ctxtmenuTabBan
            // 
            this.ctxtmenuTabBan.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ctxtmenuTabBan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNhânViênToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.gọiMónToolStripMenuItem});
            this.ctxtmenuTabBan.Location = new System.Drawing.Point(0, 0);
            this.ctxtmenuTabBan.Name = "ctxtmenuTabBan";
            this.ctxtmenuTabBan.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.ctxtmenuTabBan.Size = new System.Drawing.Size(1542, 35);
            this.ctxtmenuTabBan.TabIndex = 0;
            this.ctxtmenuTabBan.Text = "menuStrip1";
            this.ctxtmenuTabBan.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ctxtmenuTabBan_ItemClicked);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InventoryToolStripMenuItem,
            this.inputReportToolStripMenuItem,
            this.outputReportToolStripMenuItem});
            this.reportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportToolStripMenuItem.Image")));
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(111, 29);
            this.reportToolStripMenuItem.Text = "Báo cáo";
            // 
            // InventoryToolStripMenuItem
            // 
            this.InventoryToolStripMenuItem.Name = "InventoryToolStripMenuItem";
            this.InventoryToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.InventoryToolStripMenuItem.Text = "Báo cáo tồn";
            this.InventoryToolStripMenuItem.Click += new System.EventHandler(this.InventoryToolStripMenuItem_Click);
            // 
            // inputReportToolStripMenuItem
            // 
            this.inputReportToolStripMenuItem.Name = "inputReportToolStripMenuItem";
            this.inputReportToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.inputReportToolStripMenuItem.Text = "Báo cáo nhập";
            this.inputReportToolStripMenuItem.Click += new System.EventHandler(this.InputReportToolStripMenuItem_Click);
            // 
            // outputReportToolStripMenuItem
            // 
            this.outputReportToolStripMenuItem.Name = "outputReportToolStripMenuItem";
            this.outputReportToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.outputReportToolStripMenuItem.Text = "Báo cáo xuất";
            this.outputReportToolStripMenuItem.Click += new System.EventHandler(this.OutputReportToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1542, 1050);
            this.Controls.Add(this.TabHienThi);
            this.Controls.Add(this.ctxtmenuTabBan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ctxtmenuTabBan;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ctxtmenuTabHienThi.ResumeLayout(false);
            this.ctxtmenuTabBan.ResumeLayout(false);
            this.ctxtmenuTabBan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabHienThi;
        private System.Windows.Forms.ContextMenuStrip ctxtmenuTabHienThi;
        private System.Windows.Forms.ToolStripMenuItem menuItemDongTrang;
        private System.Windows.Forms.ToolStripMenuItem menuItemDongTrangAll;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gọiMónToolStripMenuItem;
        private System.Windows.Forms.MenuStrip ctxtmenuTabBan;
        private System.Windows.Forms.ToolStripMenuItem InputVoucherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuathuysanphamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerrepaidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeclareProductToolTip;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputReportToolStripMenuItem;
    }
}