using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
namespace Commonlib.join
{
    public class cNV_ThoiViecjoin
    {
        public int ID { get; set; }
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string SOQD { get; set; }
        public Nullable<System.DateTime> NgayNopDon { get; set; }
        public Nullable<System.DateTime> NgayNghi { get; set; }
        public string LyDo { get; set; }
        public string GhiChu { get; set; }
        public Nullable<int> TrangThai { get; set; }


        public virtual NhanVien NhanVien { get; set; }
    }
}
