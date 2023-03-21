using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
namespace Commonlib.join
{
   public class cNhanVienjoin
    {

        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public Nullable<bool> GioiTinh { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string CCCD { get; set; }
        public byte[] HinhAnh { get; set; }
        public Nullable<int> MaTD { get; set; }
        public string TenTD { get; set; }

        public int? MaPC { get; set; }
        public string TenPC { get; set; }
        public Nullable<int> DangLamViec { get; set; }
    }
}
