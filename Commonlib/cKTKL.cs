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
   public class cKTKL
    {
        QL_NSEntities db = new QL_NSEntities();

        public List<tb_KhenThuong_KyLuat> getList()
        {
            return db.tb_KhenThuong_KyLuat.ToList();
        }

        public List<cKTKLjoin> getListfULL()
        {
            var lstKTKL = db.tb_KhenThuong_KyLuat.ToList();
            List<cKTKLjoin> lstKTKTj = new List<cKTKLjoin>();
            cKTKLjoin ktklnvj;
            foreach (var item in lstKTKL)
            {
                ktklnvj = new cKTKLjoin();
                ktklnvj.MaNV = item.MaNV;
                ktklnvj.ID = item.ID;
                ktklnvj.SOKTKL = item.SOKTKL;
                ktklnvj.Ngay = item.Ngay;
                ktklnvj.Thang = item.Thang;
                ktklnvj.Loai = item.Loai;
                ktklnvj.SoTien = item.SoTien;
                ktklnvj.GhiChu = item.GhiChu;
                ktklnvj.Deleteby = item.Deleteby;
                var NV = db.NhanVien.FirstOrDefault(x => x.MaNV == ktklnvj.MaNV);
                ktklnvj.TenNV = NV.TenNV;
                lstKTKTj.Add(ktklnvj);

            }
            return lstKTKTj;
        }
      
        public tb_KhenThuong_KyLuat getItem(int id)
        {
            return db.tb_KhenThuong_KyLuat.FirstOrDefault(x => x.ID == id);
        }
        public tb_KhenThuong_KyLuat Add(tb_KhenThuong_KyLuat ktkl)
        {
            try
            {
                db.tb_KhenThuong_KyLuat.Add(ktkl);
                db.SaveChanges();
                return ktkl;
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.ToString());
                return ktkl;
            }
        }
        public tb_KhenThuong_KyLuat Update(tb_KhenThuong_KyLuat ktkl)
        {
            try
            {
                var _ktkl = db.tb_KhenThuong_KyLuat.FirstOrDefault(x => x.ID == ktkl.ID);
                _ktkl.MaNV = ktkl.MaNV;
                _ktkl.SOKTKL = ktkl.SOKTKL;
                _ktkl.SoTien = ktkl.SoTien;
                _ktkl.Ngay = ktkl.Ngay;
                _ktkl.Thang = ktkl.Thang;
                _ktkl.Loai = ktkl.Loai;
                _ktkl.GhiChu = ktkl.GhiChu;
                _ktkl.Deleteby = ktkl.Deleteby;
                db.SaveChanges();
                return ktkl;
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
                var _tt = db.tb_KhenThuong_KyLuat.FirstOrDefault(x => x.ID == ID);
                _tt.Deleteby = tt;
                _tt.Deleteby = tt;
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
