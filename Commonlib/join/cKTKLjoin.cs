using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
namespace Commonlib.join
{
  public  class cKTKLjoin
    {
        public int ID { get; set; }
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string SOKTKL { get; set; }
        public Nullable<int> Ngay { get; set; }
        public Nullable<int> Thang { get; set; }
        public string Loai { get; set; }
        public Nullable<double> SoTien { get; set; }
        public string GhiChu { get; set; }
        public Nullable<int> Deleteby { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
