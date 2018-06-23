namespace SoftQuanLyNhaHang.Views
{
    partial class uctInputVoucher
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
            this.textBoxRetailPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.textBoxBarCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.buttonAddToDataBase = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.productid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
=======
>>>>>>> 4641c3518ea571e8bd8d842b47e8bc57e095f0e4
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grQuanLyNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // grQuanLyNV
            // 
            this.grQuanLyNV.Controls.Add(this.textBoxRetailPrice);
            this.grQuanLyNV.Controls.Add(this.label4);
            this.grQuanLyNV.Controls.Add(this.textBox1);
            this.grQuanLyNV.Controls.Add(this.label7);
            this.grQuanLyNV.Controls.Add(this.textBoxQuantity);
            this.grQuanLyNV.Controls.Add(this.label3);
            this.grQuanLyNV.Controls.Add(this.label1);
            this.grQuanLyNV.Controls.Add(this.btnThemMoi);
            this.grQuanLyNV.Controls.Add(this.textBoxBarCode);
            this.grQuanLyNV.Controls.Add(this.label6);
            this.grQuanLyNV.Controls.Add(this.label2);
            this.grQuanLyNV.Controls.Add(this.label5);
            this.grQuanLyNV.Location = new System.Drawing.Point(4, 5);
            this.grQuanLyNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grQuanLyNV.Name = "grQuanLyNV";
            this.grQuanLyNV.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grQuanLyNV.Size = new System.Drawing.Size(498, 357);
            this.grQuanLyNV.TabIndex = 69;
            this.grQuanLyNV.TabStop = false;
            // 
            // textBoxRetailPrice
            // 
            this.textBoxRetailPrice.Location = new System.Drawing.Point(150, 237);
            this.textBoxRetailPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxRetailPrice.Name = "textBoxRetailPrice";
            this.textBoxRetailPrice.Size = new System.Drawing.Size(316, 26);
            this.textBoxRetailPrice.TabIndex = 89;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 238);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 90;
            this.label4.Text = "Đơn giá:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 164);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 26);
            this.textBox1.TabIndex = 87;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 164);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 88;
            this.label7.Text = "Nhà cung cấp:";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(150, 201);
            this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(316, 26);
            this.textBoxQuantity.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 88;
            this.label3.Text = "Số lượng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 72;
            this.label1.Text = "Nhập Hàng";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.BackColor = System.Drawing.SystemColors.Control;
            this.btnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Location = new System.Drawing.Point(354, 289);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(112, 35);
            this.btnThemMoi.TabIndex = 74;
            this.btnThemMoi.Text = "Thêm ";
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // textBoxBarCode
            // 
            this.textBoxBarCode.Location = new System.Drawing.Point(150, 79);
            this.textBoxBarCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxBarCode.Name = "textBoxBarCode";
            this.textBoxBarCode.Size = new System.Drawing.Size(316, 26);
            this.textBoxBarCode.TabIndex = 79;
            this.textBoxBarCode.TextChanged += new System.EventHandler(this.textBoxBarCode_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 24);
            this.label6.TabIndex = 85;
            this.label6.Text = "...";
            this.label6.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 85;
            this.label2.Text = "Tên sản phẩm:";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 24);
            this.label5.TabIndex = 85;
            this.label5.Text = "Mã sản phẩm:";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(713, 30);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(617, 25);
            this.label12.TabIndex = 78;
            this.label12.Text = "DANH SÁCH SẢN PHẨM TRONG ĐƠN HÀNG HIỆN TẠI";
            // 
            // dgvProductList
            // 
            this.dgvProductList.AllowUserToAddRows = false;
            this.dgvProductList.AllowUserToDeleteRows = false;
            this.dgvProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductList.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productid,
            this.productname,
            this.Ncc,
            this.quantity,
            this.inputprice,
            this.total});
            this.dgvProductList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvProductList.Location = new System.Drawing.Point(550, 76);
            this.dgvProductList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.Size = new System.Drawing.Size(1022, 286);
            this.dgvProductList.TabIndex = 60;
            this.dgvProductList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachNV_CellContentClick);
            // 
            // buttonAddToDataBase
            // 
            this.buttonAddToDataBase.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAddToDataBase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddToDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddToDataBase.Location = new System.Drawing.Point(1460, 379);
            this.buttonAddToDataBase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddToDataBase.Name = "buttonAddToDataBase";
            this.buttonAddToDataBase.Size = new System.Drawing.Size(112, 35);
            this.buttonAddToDataBase.TabIndex = 74;
            this.buttonAddToDataBase.Text = "Nhập";
            this.buttonAddToDataBase.UseVisualStyleBackColor = false;
            this.buttonAddToDataBase.Click += new System.EventHandler(this.buttonAddToDataBase_Click);
            // 
<<<<<<< HEAD
            // productid
=======
            // total
>>>>>>> 4641c3518ea571e8bd8d842b47e8bc57e095f0e4
            // 
            this.total.HeaderText = "Thành tiền";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // inputprice
            // 
            this.inputprice.HeaderText = "Đơn giá";
            this.inputprice.Name = "inputprice";
            this.inputprice.ReadOnly = true;
            // 
            // Ncc
            // 
            this.Ncc.HeaderText = "Nhà cung cấp";
            this.Ncc.Name = "Ncc";
            this.Ncc.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Số lượng";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // productname
            // 
            this.productname.HeaderText = "Tên sản phẩm";
            this.productname.Name = "productname";
            this.productname.ReadOnly = true;
            // 
            // productid
            // 
            this.productid.HeaderText = "Mã sản phẩm";
            this.productid.Name = "productid";
            this.productid.ReadOnly = true;
            // 
            // uctInputVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.grQuanLyNV);
            this.Controls.Add(this.dgvProductList);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonAddToDataBase);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "uctInputVoucher";
            this.Size = new System.Drawing.Size(1910, 951);
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
        private System.Windows.Forms.TextBox textBoxRetailPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.Button buttonAddToDataBase;
<<<<<<< HEAD
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
=======
>>>>>>> 4641c3518ea571e8bd8d842b47e8bc57e095f0e4
        private System.Windows.Forms.DataGridViewTextBoxColumn productid;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}
