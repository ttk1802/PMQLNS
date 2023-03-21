using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Commonlib.join;
using System.Windows.Forms;

namespace Commonlib
{
    class cNhanVien_ThoiViec
    {
        QL_NSEntities db = new QL_NSEntities();

        public List<tb_TinhTrangNV> getList()
        {
            return db.tb_TinhTrangNV.ToList();
        }

        public List<cNV_ThoiViecjoin> getListfULL()
        {
            var lstNhanVienTT = db.tb_TinhTrangNV.ToList();
            List<cNV_ThoiViecjoin> lstnvj = new List<cNV_ThoiViecjoin>();
            cNV_ThoiViecjoin nvTTj;
            foreach (var item in lstNhanVienTT)
            {
                nvTTj = new cNV_ThoiViecjoin();
                nvTTj.MaNV = item.MaNV;
                nvTTj.ID = item.ID;
                nvTTj.NgayNghi = item.NgayNghi;
                nvTTj.NgayNopDon = item.NgayNopDon;
                nvTTj.GhiChu = item.GhiChu;
                nvTTj.TrangThai = item.TrangThai;
                nvTTj.LyDo = item.LyDo;
                var NV = db.NhanVien.FirstOrDefault(x => x.MaNV == nvTTj.MaNV);
                nvTTj.TenNV = NV.TenNV;
                lstnvj.Add(nvTTj);

            }
            return lstnvj;
        }

        public tb_TinhTrangNV getItem(int id)
        {
            return db.tb_TinhTrangNV.FirstOrDefault(x => x.ID == id);
        }
        public tb_TinhTrangNV Add(tb_TinhTrangNV TT)
        {
            try
            {
                db.tb_TinhTrangNV.Add(TT);
                db.SaveChanges();
                return TT;
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.ToString());
                return TT;
            }
        }
        public tb_TinhTrangNV Update(tb_TinhTrangNV TT)
        {
            try
            {
                var _tt = db.tb_TinhTrangNV.FirstOrDefault(x => x.ID == TT.ID);
                _tt.NgayNopDon = TT.NgayNopDon;
                _tt.NgayNghi = TT.NgayNghi;
                _tt.SOQD = TT.SOQD;
                _tt.LyDo = TT.LyDo;
                _tt.GhiChu = TT.GhiChu;
                _tt.TrangThai = TT.TrangThai;
                db.SaveChanges();
                return TT;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(int ID, int tt)
        {
            try
            {
                var _tt = db.tb_TinhTrangNV.FirstOrDefault(x => x.ID == ID);
                _tt.TrangThai = tt;
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
