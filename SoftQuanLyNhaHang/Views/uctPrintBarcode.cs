using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace SoftQuanLyNhaHang.Views
{
    public partial class uctPrintBarcode : UserControl
    {
        public uctPrintBarcode()
        {
            InitializeComponent();
        }

        private void txtMaSanPham_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string barcode = txtMaSanPham.Text;

                //Bitmap bitm = new Bitmap(barcode.Length * 10, 60);
                Bitmap bitm = new Bitmap(300, 60);
                using (Graphics graphic = Graphics.FromImage(bitm))
                {
                    //Font newfont = new Font("3 of 9 Barcode", 20);
                    Font newfont = new Font("IDAHC39M Code 39 Barcode", 11);
                    PointF point = new PointF(2f, 2f);
                    SolidBrush black = new SolidBrush(Color.Black);
                    SolidBrush white = new SolidBrush(Color.White);
                    graphic.FillRectangle(white, 0, 0, bitm.Width, bitm.Height);
                    graphic.DrawString("*" + barcode + "*", newfont, black, point);
                }

                using (MemoryStream Mmst = new MemoryStream())
                {
                    //bitm.Save("ms", ImageFormat.Jpeg);
                    picBarcode.Image = bitm;
                    picBarcode.Width = bitm.Width;
                    picBarcode.Height = bitm.Height;
                }
            }
            catch { }
          
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //int width = Convert.ToInt32(txtBarcode.Width);
            //int height = Convert.ToInt32(txtBarcode.Height);
            //Bitmap bmp = new Bitmap(width, height);
            //txtBarcode.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
            //bmp.Save("Barcode" + txtBarcode.Text, ImageFormat.Png);
            using (var fbd = new FolderBrowserDialog())
            {
                using (var folderDialog = new FolderBrowserDialog())
                {
                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        int width = picBarcode.Width;
                        int height = picBarcode.Height;
                        Bitmap bmp = new Bitmap(width, height);
                        picBarcode.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                        bmp.Save(folderDialog.SelectedPath+"\\Barcode" + txtMaSanPham.Text + ".png", ImageFormat.Png);
                        MessageBox.Show("Lưu thành công"); // your result
                    }
                }
            }

        }
    }
}
