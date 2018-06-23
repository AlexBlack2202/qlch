using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftQuanLyNhaHang.Models
{
  public  class OutputVoucherBO
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string Quantity { get; set; }
        public string SellPrice { get; set; }
        public string Total { get; set; }
    }
}
