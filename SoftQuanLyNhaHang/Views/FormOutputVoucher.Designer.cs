namespace SoftQuanLyNhaHang.Views
{
    partial class FormOutputVoucher
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
            this.buttonExport = new System.Windows.Forms.Button();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(225, 41);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(88, 33);
            this.buttonExport.TabIndex = 3;
            this.buttonExport.Text = "Xuất file";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDate.Location = new System.Drawing.Point(96, 45);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(91, 20);
            this.dateTimePickerDate.TabIndex = 2;
            // 
            // FormOutputVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 132);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.dateTimePickerDate);
            this.Name = "FormOutputVoucher";
            this.Text = "Báo cáo xuất";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
    }
}