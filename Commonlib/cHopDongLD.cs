using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using Commonlib.join;

namespace Commonlib
{
  public class cHopDongLD
    {
        QL_NSEntities db = new QL_NSEntities();
        public List<tb_HopDong> getlist()
        {
            return db.tb_HopDong.ToList();
        }

        public List<cHopDongjoin> getlistfull()
        {
            var lstPC = db.tb_HopDong.ToList();
            List<cHopDongjoin> lstHDjoin = new List<cHopDongjoin>();
            cHopDongjoin hdj;
            foreach (var item in lstPC)
            {
                hdj = new cHopDongjoin();
                hdj.MaNV = item.MaNV;
                hdj.MaHD = item.MaHD;
                hdj.SOHD = item.SOHD;
                hdj.Tungay = item.Tungay;
                hdj.Denngay = item.Denngay;
                hdj.ThoiHan = item.ThoiHan;
                hdj.NoiDung = item.NoiDung;
                hdj.LoaiHD = item.LoaiHD;
                hdj.NgayKy = item.NgayKy;
                var nv = db.NhanVien.FirstOrDefault(x => x.MaNV == item.MaNV);
                hdj.TenNV = nv.TenNV;
                lstHDjoin.Add(hdj);
            }
            return lstHDjoin;
        }

        public tb_HopDong getitem(int id)
        {
            return db.tb_HopDong.FirstOrDefault(x => x.MaHD == id);
        }
        public tb_HopDong Add(tb_HopDong hd)
        {
            try
            {
                db.tb_HopDong.Add(hd);
                db.SaveChanges();
                return hd;
            }
            catch (Exception ex)
            {

                throw new Exception("Error" + ex.ToString()); ;
            }
        }

        public tb_HopDong Update(tb_HopDong hd)
        {
            try
            {
                var _hd = db.tb_HopDong.FirstOrDefault(x => x.MaHD == hd.MaHD);
                _hd.MaNV = hd.MaNV;
                _hd.SOHD = hd.SOHD;
                _hd.LoaiHD = hd.LoaiHD;
                _hd.NgayKy = hd.NgayKy;
                _hd.Tungay = hd.Tungay;
                _hd.Denngay = hd.Denngay;
                _hd.NoiDung = hd.NoiDung;
                _hd.ThoiHan = hd.ThoiHan;


                db.SaveChanges();
                return hd;
            }
            catch (Exception ex)
            {

                throw new Exception("Error" + ex.ToString()); ;
            }
        }
        public void Delete(int id)
        {
            try
            {
                var _hd = db.tb_HopDong.FirstOrDefault(x => x.MaHD == id);
                db.tb_HopDong.Remove(_hd);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
    }
}
