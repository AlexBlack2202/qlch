﻿namespace SoftQuanLyNhaHang.Views
{
    partial class uctProductDestroy
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
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBarCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grQuanLyNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // grQuanLyNV
            // 
            this.grQuanLyNV.Controls.Add(this.textBoxQuantity);
            this.grQuanLyNV.Controls.Add(this.btnThemMoi);
            this.grQuanLyNV.Controls.Add(this.label3);
            this.grQuanLyNV.Controls.Add(this.textBoxBarCode);
            this.grQuanLyNV.Controls.Add(this.label5);
            this.grQuanLyNV.Controls.Add(this.label2);
            this.grQuanLyNV.Controls.Add(this.labelProductName);
            this.grQuanLyNV.Location = new System.Drawing.Point(18, 85);
            this.grQuanLyNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grQuanLyNV.Name = "grQuanLyNV";
            this.grQuanLyNV.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grQuanLyNV.Size = new System.Drawing.Size(493, 242);
            this.grQuanLyNV.TabIndex = 69;
            this.grQuanLyNV.TabStop = false;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(138, 125);
            this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(316, 26);
            this.textBoxQuantity.TabIndex = 87;
            this.textBoxQuantity.Text = "0";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.BackColor = System.Drawing.SystemColors.Control;
            this.btnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Location = new System.Drawing.Point(342, 180);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(112, 35);
            this.btnThemMoi.TabIndex = 74;
            this.btnThemMoi.Text = "Xuất huỷ";
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 88;
            this.label3.Text = "Số lượng:";
            // 
            // textBoxBarCode
            // 
            this.textBoxBarCode.Location = new System.Drawing.Point(138, 25);
            this.textBoxBarCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxBarCode.Name = "textBoxBarCode";
            this.textBoxBarCode.Size = new System.Drawing.Size(316, 26);
            this.textBoxBarCode.TabIndex = 79;
            this.textBoxBarCode.TextChanged += new System.EventHandler(this.textBoxBarCode_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 24);
            this.label5.TabIndex = 85;
            this.label5.Text = "Mã sản phẩm:";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(134, 80);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(21, 20);
            this.labelProductName.TabIndex = 86;
            this.labelProductName.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 72;
            this.label1.Text = "Xuất huỷ sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 86;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // uctProductDestroy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.grQuanLyNV);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "uctProductDestroy";
            this.Size = new System.Drawing.Size(1910, 951);
            this.Load += new System.EventHandler(this.uctNhanVien_Load);
            this.grQuanLyNV.ResumeLayout(false);
            this.grQuanLyNV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grQuanLyNV;
        private System.Windows.Forms.TextBox textBoxBarCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
