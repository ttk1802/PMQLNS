using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
namespace Commonlib.join
{
   public class cLuongNVjoin
    {
        public int ID { get; set; }
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public Nullable<double> LCB { get; set; }
        public Nullable<System.DateTime> ThoiGian { get; set; }
        public Nullable<bool> TrangThai { get; set; }
        public Nullable<int> Deleteby { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
