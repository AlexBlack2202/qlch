namespace SoftQuanLyNhaHang.Views
{
    partial class uctCustomerRepaid
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
            this.grQuanLyNV = new System.Windows.Forms.GroupBox();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOutputVoucherID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBarCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.buttonCustomerRepaid = new System.Windows.Forms.Button();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelTotalReturnMoney = new System.Windows.Forms.Label();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outputvoucherid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grQuanLyNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // grQuanLyNV
            // 
            this.grQuanLyNV.Controls.Add(this.btnThemMoi);
            this.grQuanLyNV.Controls.Add(this.textBoxQuantity);
            this.grQuanLyNV.Controls.Add(this.labelProductName);
            this.grQuanLyNV.Controls.Add(this.label3);
            this.grQuanLyNV.Controls.Add(this.textBoxOutputVoucherID);
            this.grQuanLyNV.Controls.Add(this.label2);
            this.grQuanLyNV.Controls.Add(this.textBoxBarCode);
            this.grQuanLyNV.Controls.Add(this.label5);
            this.grQuanLyNV.Location = new System.Drawing.Point(608, 61);
            this.grQuanLyNV.Name = "grQuanLyNV";
            this.grQuanLyNV.Size = new System.Drawing.Size(407, 266);
            this.grQuanLyNV.TabIndex = 69;
            this.grQuanLyNV.TabStop = false;
            this.grQuanLyNV.Enter += new System.EventHandler(this.grQuanLyNV_Enter);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.BackColor = System.Drawing.SystemColors.Control;
            this.btnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Location = new System.Drawing.Point(177, 217);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(90, 29);
            this.btnThemMoi.TabIndex = 74;
            this.btnThemMoi.Text = "Thêm ";
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(116, 161);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(212, 20);
            this.textBoxQuantity.TabIndex = 87;
            this.textBoxQuantity.TextChanged += new System.EventHandler(this.textBoxQuantity_TextChanged);
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(117, 121);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(0, 13);
            this.labelProductName.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 88;
            this.label3.Text = "Số lượng khách trả:";
            // 
            // textBoxOutputVoucherID
            // 
            this.textBoxOutputVoucherID.Location = new System.Drawing.Point(116, 35);
            this.textBoxOutputVoucherID.Name = "textBoxOutputVoucherID";
            this.textBoxOutputVoucherID.Size = new System.Drawing.Size(212, 20);
            this.textBoxOutputVoucherID.TabIndex = 79;
            this.textBoxOutputVoucherID.TextChanged += new System.EventHandler(this.textBoxOutputVoucherID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 85;
            this.label2.Text = "Mã đơn hàng:";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // textBoxBarCode
            // 
            this.textBoxBarCode.Location = new System.Drawing.Point(116, 77);
            this.textBoxBarCode.Name = "textBoxBarCode";
            this.textBoxBarCode.Size = new System.Drawing.Size(212, 20);
            this.textBoxBarCode.TabIndex = 79;
            this.textBoxBarCode.TextChanged += new System.EventHandler(this.textBoxBarCode_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 85;
            this.label5.Text = "Mã sản phẩm:";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(748, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 72;
            this.label1.Text = "NHẬP TRẢ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(162, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 17);
            this.label6.TabIndex = 89;
            this.label6.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // dgvProductList
            // 
            this.dgvProductList.AllowUserToAddRows = false;
            this.dgvProductList.AllowUserToDeleteRows = false;
            this.dgvProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.productname,
            this.quantity,
            this.InputPrice,
            this.Total,
            this.productid,
            this.outputvoucherid});
            this.dgvProductList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvProductList.Location = new System.Drawing.Point(23, 60);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.Size = new System.Drawing.Size(537, 446);
            this.dgvProductList.TabIndex = 90;
            // 
            // buttonCustomerRepaid
            // 
            this.buttonCustomerRepaid.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCustomerRepaid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCustomerRepaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustomerRepaid.Location = new System.Drawing.Point(768, 466);
            this.buttonCustomerRepaid.Name = "buttonCustomerRepaid";
            this.buttonCustomerRepaid.Size = new System.Drawing.Size(75, 23);
            this.buttonCustomerRepaid.TabIndex = 74;
            this.buttonCustomerRepaid.Text = "Nhập trả";
            this.buttonCustomerRepaid.UseVisualStyleBackColor = false;
            this.buttonCustomerRepaid.Click += new System.EventHandler(this.buttonCustomerRepaid_Click);
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Location = new System.Drawing.Point(725, 402);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(0, 13);
            this.labelTotalPrice.TabIndex = 91;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(631, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 91;
            this.label8.Text = "Tổng tiền trả lại khách:";
            // 
            // labelTotalReturnMoney
            // 
            this.labelTotalReturnMoney.AutoSize = true;
            this.labelTotalReturnMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalReturnMoney.ForeColor = System.Drawing.Color.Red;
            this.labelTotalReturnMoney.Location = new System.Drawing.Point(753, 402);
            this.labelTotalReturnMoney.Name = "labelTotalReturnMoney";
            this.labelTotalReturnMoney.Size = new System.Drawing.Size(15, 16);
            this.labelTotalReturnMoney.TabIndex = 91;
            this.labelTotalReturnMoney.Text = "0";
            // 
            // stt
            // 
            this.stt.DataPropertyName = "IdBan";
            this.stt.HeaderText = "Stt";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            // 
            // productname
            // 
            this.productname.DataPropertyName = "TenSanPham";
            this.productname.HeaderText = "Tên sản phẩm";
            this.productname.Name = "productname";
            this.productname.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "SoLuong";
            this.quantity.HeaderText = "Số lượng";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // InputPrice
            // 
            this.InputPrice.DataPropertyName = "DonGia";
            this.InputPrice.HeaderText = "Đơn giá";
            this.InputPrice.Name = "InputPrice";
            this.InputPrice.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Thành tiền";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // productid
            // 
            this.productid.HeaderText = "Mã sản phẩm";
            this.productid.Name = "productid";
            this.productid.ReadOnly = true;
            this.productid.Visible = false;
            // 
            // outputvoucherid
            // 
            this.outputvoucherid.HeaderText = "Mã đơn hàng";
            this.outputvoucherid.Name = "outputvoucherid";
            this.outputvoucherid.ReadOnly = true;
            this.outputvoucherid.Visible = false;
            // 
            // uctCustomerRepaid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.labelTotalReturnMoney);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonCustomerRepaid);
            this.Controls.Add(this.dgvProductList);
            this.Controls.Add(this.grQuanLyNV);
            this.Controls.Add(this.label1);
            this.Name = "uctCustomerRepaid";
            this.Size = new System.Drawing.Size(1273, 618);
            this.Load += new System.EventHandler(this.uctNhanVien_Load);
            this.grQuanLyNV.ResumeLayout(false);
            this.grQuanLyNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grQuanLyNV;
        private System.Windows.Forms.TextBox textBoxBarCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOutputVoucherID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Button buttonCustomerRepaid;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelTotalReturnMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn InputPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn productid;
        private System.Windows.Forms.DataGridViewTextBoxColumn outputvoucherid;
    }
}
