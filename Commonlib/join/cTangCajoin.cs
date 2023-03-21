using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
namespace Commonlib.join
{
   public class cTangCajoin
    {
        public int ID { get; set; }

        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public Nullable<int> nam { get; set; }
        public Nullable<int> thang { get; set; }
        public Nullable<double> SoGio { get; set; }
        public int? IDLoaiCa { get; set; }
        public string TenLoaiCa { get; set; }
        public Nullable<double> HeSo { get; set; }
        public string GhiChu { get; set; }
        public Nullable<int> TrangThai { get; set; }
        public double? SoTien { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual tb_LoaiCa tb_LoaiCa { get; set; }
    }
}
