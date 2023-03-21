using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
namespace Commonlib.join
{
    public class cPhuCapjoin
    {
        public string TenNV { get; set; }
        public string TenPCap { get; set; }
        public int ID { get; set; }
        public Nullable<int> Delete_by { get; set; }
        public int MaPCap { get; set; }
        public string MaNV { get; set; }
        public Nullable<System.DateTime> Ngay { get; set; }
        public string NoiDung { get; set; }
        public Nullable<double> SoTien { get; set; }
    }
}
