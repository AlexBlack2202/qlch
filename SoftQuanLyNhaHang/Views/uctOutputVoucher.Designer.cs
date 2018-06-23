﻿namespace SoftQuanLyNhaHang.Views
{
    partial class uctOutputVoucher
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctOutputVoucher));
            this.grDanhSachBan = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachSanPham = new System.Windows.Forms.DataGridView();
            this.IdBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RetailPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.grThongTinBan = new System.Windows.Forms.GroupBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSoLuong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBarCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonPrintInvoice = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelReturnMoney = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxCustomerMoney = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grDanhSachBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSanPham)).BeginInit();
            this.grThongTinBan.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grDanhSachBan
            // 
            this.grDanhSachBan.Controls.Add(this.dgvDanhSachSanPham);
            this.grDanhSachBan.Location = new System.Drawing.Point(4, 89);
            this.grDanhSachBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grDanhSachBan.Name = "grDanhSachBan";
            this.grDanhSachBan.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grDanhSachBan.Size = new System.Drawing.Size(814, 525);
            this.grDanhSachBan.TabIndex = 90;
            this.grDanhSachBan.TabStop = false;
            // 
            // dgvDanhSachSanPham
            // 
            this.dgvDanhSachSanPham.AllowUserToAddRows = false;
            this.dgvDanhSachSanPham.AllowUserToDeleteRows = false;
            this.dgvDanhSachSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachSanPham.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDanhSachSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdBan,
            this.ProductID,
            this.ProductName,
            this.Quantity,
            this.RetailPrice,
            this.total});
            this.dgvDanhSachSanPham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDanhSachSanPham.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvDanhSachSanPham.Location = new System.Drawing.Point(4, 20);
            this.dgvDanhSachSanPham.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDanhSachSanPham.Name = "dgvDanhSachSanPham";
            this.dgvDanhSachSanPham.ReadOnly = true;
            this.dgvDanhSachSanPham.Size = new System.Drawing.Size(806, 500);
            this.dgvDanhSachSanPham.TabIndex = 88;
            // 
            // IdBan
            // 
            this.IdBan.DataPropertyName = "IdBan";
            this.IdBan.HeaderText = "Stt";
            this.IdBan.Name = "IdBan";
            this.IdBan.ReadOnly = true;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Mã Sản Phẩm";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Visible = false;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Tên sản phẩm";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "SoLuong";
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // RetailPrice
            // 
            this.RetailPrice.DataPropertyName = "DonGia";
            this.RetailPrice.HeaderText = "Đơn Giá";
            this.RetailPrice.Name = "RetailPrice";
            this.RetailPrice.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Thành tiền";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 25);
            this.label1.TabIndex = 87;
            this.label1.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // grThongTinBan
            // 
            this.grThongTinBan.Controls.Add(this.labelProductName);
            this.grThongTinBan.Controls.Add(this.btnThemMoi);
            this.grThongTinBan.Controls.Add(this.label3);
            this.grThongTinBan.Controls.Add(this.textBoxSoLuong);
            this.grThongTinBan.Controls.Add(this.label2);
            this.grThongTinBan.Controls.Add(this.textBoxBarCode);
            this.grThongTinBan.Controls.Add(this.label6);
            this.grThongTinBan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grThongTinBan.Location = new System.Drawing.Point(852, 89);
            this.grThongTinBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grThongTinBan.Name = "grThongTinBan";
            this.grThongTinBan.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grThongTinBan.Size = new System.Drawing.Size(524, 269);
            this.grThongTinBan.TabIndex = 99;
            this.grThongTinBan.TabStop = false;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.Location = new System.Drawing.Point(172, 91);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(0, 26);
            this.labelProductName.TabIndex = 94;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Location = new System.Drawing.Point(362, 197);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(146, 49);
            this.btnThemMoi.TabIndex = 100;
            this.btnThemMoi.Text = "Thêm ";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 22);
            this.label3.TabIndex = 94;
            this.label3.Text = "Tên sản phẩm:";
            // 
            // textBoxSoLuong
            // 
            this.textBoxSoLuong.Location = new System.Drawing.Point(172, 146);
            this.textBoxSoLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSoLuong.Name = "textBoxSoLuong";
            this.textBoxSoLuong.Size = new System.Drawing.Size(336, 30);
            this.textBoxSoLuong.TabIndex = 89;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 91;
            this.label2.Text = "Số lượng:";
            // 
            // textBoxBarCode
            // 
            this.textBoxBarCode.Location = new System.Drawing.Point(172, 38);
            this.textBoxBarCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxBarCode.Name = "textBoxBarCode";
            this.textBoxBarCode.Size = new System.Drawing.Size(336, 30);
            this.textBoxBarCode.TabIndex = 93;
            this.textBoxBarCode.TabStop = false;
            this.textBoxBarCode.TextChanged += new System.EventHandler(this.txtIdBan_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 22);
            this.label6.TabIndex = 92;
            this.label6.Text = "Barcode:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1010, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 25);
            this.label4.TabIndex = 87;
            this.label4.Text = "THÔNG TIN SẢN PHẨM";
            // 
            // buttonPrintInvoice
            // 
            this.buttonPrintInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPrintInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPrintInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrintInvoice.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrintInvoice.Image")));
            this.buttonPrintInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPrintInvoice.Location = new System.Drawing.Point(1147, 620);
            this.buttonPrintInvoice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPrintInvoice.Name = "buttonPrintInvoice";
            this.buttonPrintInvoice.Size = new System.Drawing.Size(229, 85);
            this.buttonPrintInvoice.TabIndex = 101;
            this.buttonPrintInvoice.Text = "In hoá đơn";
            this.buttonPrintInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPrintInvoice.UseVisualStyleBackColor = true;
            this.buttonPrintInvoice.Click += new System.EventHandler(this.buttonPrintInvoice_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelReturnMoney);
            this.groupBox1.Controls.Add(this.labelTotal);
            this.groupBox1.Controls.Add(this.textBoxCustomerMoney);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(852, 395);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(524, 215);
            this.groupBox1.TabIndex = 99;
            this.groupBox1.TabStop = false;
            // 
            // labelReturnMoney
            // 
            this.labelReturnMoney.AutoSize = true;
            this.labelReturnMoney.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturnMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelReturnMoney.Location = new System.Drawing.Point(214, 158);
            this.labelReturnMoney.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReturnMoney.Name = "labelReturnMoney";
            this.labelReturnMoney.Size = new System.Drawing.Size(29, 32);
            this.labelReturnMoney.TabIndex = 94;
            this.labelReturnMoney.Text = "0";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.Red;
            this.labelTotal.Location = new System.Drawing.Point(214, 34);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(29, 32);
            this.labelTotal.TabIndex = 94;
            this.labelTotal.Text = "0";
            // 
            // textBoxCustomerMoney
            // 
            this.textBoxCustomerMoney.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerMoney.Location = new System.Drawing.Point(218, 98);
            this.textBoxCustomerMoney.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCustomerMoney.Name = "textBoxCustomerMoney";
            this.textBoxCustomerMoney.Size = new System.Drawing.Size(289, 35);
            this.textBoxCustomerMoney.TabIndex = 89;
            this.textBoxCustomerMoney.TextChanged += new System.EventHandler(this.textBoxCustomerMoney_TextChanged);
            this.textBoxCustomerMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCustomerMoney_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 100);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 28);
            this.label9.TabIndex = 91;
            this.label9.Text = "Tiền khách đưa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 28);
            this.label5.TabIndex = 92;
            this.label5.Text = "Tiền trả lại khách:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 38);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 28);
            this.label10.TabIndex = 92;
            this.label10.Text = "Tổng tiền:";
            // 
            // uctOutputVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonPrintInvoice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grThongTinBan);
            this.Controls.Add(this.grDanhSachBan);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "uctOutputVoucher";
            this.Size = new System.Drawing.Size(1395, 705);
            this.Load += new System.EventHandler(this.uctBan_Load);
            this.grDanhSachBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSanPham)).EndInit();
            this.grThongTinBan.ResumeLayout(false);
            this.grThongTinBan.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grDanhSachBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grThongTinBan;
        private System.Windows.Forms.TextBox textBoxSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBarCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.DataGridView dgvDanhSachSanPham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonPrintInvoice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelReturnMoney;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxCustomerMoney;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn RetailPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}
