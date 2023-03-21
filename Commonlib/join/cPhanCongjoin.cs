using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
namespace Commonlib.join
{
   public class cPhanCongjoin
    {
        public int MaPC { get; set; }
        public string TenPC { get; set; }
        public int MaPB { get; set; }
        public string TenPB { get; set; }
        public int MaCV { get; set; }
        public string TenCV { get; set; }
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public Nullable<System.DateTime> ThoiGian { get; set; }
        public Nullable<bool> TrangThai { get; set; }
    }
}
