using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftQuanLyNhaHang.Utils
{
    public class Config
    {
        public static string DBCon = System.Configuration.ConfigurationManager.AppSettings["DBCon"].ToString();
    }
}
