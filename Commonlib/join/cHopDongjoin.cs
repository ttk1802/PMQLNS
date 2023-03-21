using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
namespace Commonlib.join
{
    
        public partial class cHopDongjoin
        {
            public int MaHD { get; set; }
            public string SOHD { get; set; }
            public string MaNV { get; set; }
            public string TenNV { get; set; }
            public string LoaiHD { get; set; }
            public Nullable<System.DateTime> Tungay { get; set; }
            public Nullable<System.DateTime> Denngay { get; set; }
            public Nullable<System.DateTime> NgayKy { get; set; }
            public string NoiDung { get; set; }
            public string ThoiHan { get; set; }

            public virtual NhanVien NhanVien { get; set; }
        }
    
}
