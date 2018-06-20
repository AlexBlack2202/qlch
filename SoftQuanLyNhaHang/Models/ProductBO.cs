using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftQuanLyNhaHang.Models
{
    public class ProductBO
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public double SellPrice { get; set; }
    }

    public class OutputVoucherDetail
    {
        public string ProductID { get; set; }
        public long OutputVoucherDetailID { get; set; }
        public long OutputVoucherID { get; set; }
        public double SalePrice { get; set; }
    }
}
