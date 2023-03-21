using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commonlib.join
{
    public class cUngLuongjoin
    {
        public int ID { get; set; }
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public Nullable<int> Ngay { get; set; }
        public Nullable<int> Thang { get; set; }
        public Nullable<int> Nam { get; set; }
        public Nullable<double> SoTien { get; set; }
        public Nullable<int> TrangThai { get; set; }
        public string GhiChu { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
