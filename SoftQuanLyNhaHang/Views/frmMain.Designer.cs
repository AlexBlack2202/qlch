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
            this.InputVoucherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuathuysanphamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerrepaidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gọiMónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxtmenuTabBan = new System.Windows.Forms.MenuStrip();
            this.DeclareProductToolTip = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxtmenuTabHienThi.SuspendLayout();
            this.ctxtmenuTabBan.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabHienThi
            // 
            this.TabHienThi.ContextMenuStrip = this.ctxtmenuTabHienThi;
            this.TabHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabHienThi.Location = new System.Drawing.Point(0, 24);
            this.TabHienThi.Name = "TabHienThi";
            this.TabHienThi.SelectedIndex = 0;
            this.TabHienThi.Size = new System.Drawing.Size(1028, 718);
            this.TabHienThi.TabIndex = 1;
            // 
            // ctxtmenuTabHienThi
            // 
            this.ctxtmenuTabHienThi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDongTrang,
            this.menuItemDongTrangAll});
            this.ctxtmenuTabHienThi.Name = "ctxtmenuTabHienThi";
            this.ctxtmenuTabHienThi.Size = new System.Drawing.Size(177, 48);
            // 
            // menuItemDongTrang
            // 
            this.menuItemDongTrang.Name = "menuItemDongTrang";
            this.menuItemDongTrang.Size = new System.Drawing.Size(176, 22);
            this.menuItemDongTrang.Text = "Đóng trang hiện tại";
            this.menuItemDongTrang.Click += new System.EventHandler(this.menuItemDongTrang_Click);
            // 
            // menuItemDongTrangAll
            // 
            this.menuItemDongTrangAll.Name = "menuItemDongTrangAll";
            this.menuItemDongTrangAll.Size = new System.Drawing.Size(176, 22);
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
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý ";
            // 
            // InputVoucherToolStripMenuItem
            // 
            this.InputVoucherToolStripMenuItem.Name = "InputVoucherToolStripMenuItem";
            this.InputVoucherToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.InputVoucherToolStripMenuItem.Text = "Nhập kho";
            this.InputVoucherToolStripMenuItem.Click += new System.EventHandler(this.InputVoucherToolStripMenuItem_Click);
            // 
            // xuathuysanphamToolStripMenuItem
            // 
            this.xuathuysanphamToolStripMenuItem.Name = "xuathuysanphamToolStripMenuItem";
            this.xuathuysanphamToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.xuathuysanphamToolStripMenuItem.Text = "Xuất huỷ sản phẩm";
            this.xuathuysanphamToolStripMenuItem.Click += new System.EventHandler(this.xuathuysanphamToolStripMenuItem_Click);
            // 
            // customerrepaidToolStripMenuItem
            // 
            this.customerrepaidToolStripMenuItem.Name = "customerrepaidToolStripMenuItem";
            this.customerrepaidToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.customerrepaidToolStripMenuItem.Text = "Khách hàng trả hàng";
            this.customerrepaidToolStripMenuItem.Click += new System.EventHandler(this.customerrepaidToolStripMenuItem_Click);
            // 
            // gọiMónToolStripMenuItem
            // 
            this.gọiMónToolStripMenuItem.Name = "gọiMónToolStripMenuItem";
            this.gọiMónToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.gọiMónToolStripMenuItem.Text = "Bán hàng";
            this.gọiMónToolStripMenuItem.Click += new System.EventHandler(this.gọiMónToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thoátToolStripMenuItem.Image")));
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // ctxtmenuTabBan
            // 
            this.ctxtmenuTabBan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNhânViênToolStripMenuItem,
            this.gọiMónToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.ctxtmenuTabBan.Location = new System.Drawing.Point(0, 0);
            this.ctxtmenuTabBan.Name = "ctxtmenuTabBan";
            this.ctxtmenuTabBan.Size = new System.Drawing.Size(1028, 24);
            this.ctxtmenuTabBan.TabIndex = 0;
            this.ctxtmenuTabBan.Text = "menuStrip1";
            this.ctxtmenuTabBan.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ctxtmenuTabBan_ItemClicked);
            // 
            // DeclareProductToolTip
            // 
            this.DeclareProductToolTip.Name = "DeclareProductToolTip";
            this.DeclareProductToolTip.Size = new System.Drawing.Size(184, 22);
            this.DeclareProductToolTip.Text = "Khai báo sản phẩm";
            this.DeclareProductToolTip.Click += new System.EventHandler(this.DeclareProductToolTip_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 742);
            this.Controls.Add(this.TabHienThi);
            this.Controls.Add(this.ctxtmenuTabBan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ctxtmenuTabBan;
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
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.MenuStrip ctxtmenuTabBan;
        private System.Windows.Forms.ToolStripMenuItem InputVoucherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuathuysanphamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerrepaidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeclareProductToolTip;
    }
}