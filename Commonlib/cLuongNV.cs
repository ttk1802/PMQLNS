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
   public class cLuongNV
    {

        QL_NSEntities db = new QL_NSEntities();

        public List<tb_Luong_NV> getList()
        {
            return db.tb_Luong_NV.ToList();
        }

        public List<cLuongNVjoin> getListfULL()
        {
            var lstLuongNV = db.tb_Luong_NV.ToList();
            List<cLuongNVjoin> lstnvj = new List<cLuongNVjoin>();
            cLuongNVjoin luongnvj;
            foreach (var item in lstLuongNV)
            {
                luongnvj = new cLuongNVjoin();
                luongnvj.MaNV = item.MaNV;
                luongnvj.ID = item.ID;
                luongnvj.LCB = item.LCB;
                luongnvj.ThoiGian = item.ThoiGian;
                luongnvj.TrangThai = item.TrangThai;
                luongnvj.Deleteby = item.Deleteby;
                var NV = db.NhanVien.FirstOrDefault(x => x.MaNV == luongnvj.MaNV);
                luongnvj.TenNV = NV.TenNV;
                lstnvj.Add(luongnvj);

            }
            return lstnvj;
        }
        public tb_Luong_NV UpdateItem(tb_Luong_NV lnv, string manv)
        {
            var lstlnvItem = db.tb_Luong_NV.Where(x => x.MaNV == manv).ToList();

            foreach (var item in lstlnvItem)
            {
                lnv.TrangThai = item.TrangThai = false;
            }
            db.SaveChanges();
            return lnv;
        }
        public tb_Luong_NV getItem(int id)
        {
            return db.tb_Luong_NV.FirstOrDefault(x => x.ID == id);
        }
        public tb_Luong_NV Add(tb_Luong_NV lnv)
        {
            try
            {
                db.tb_Luong_NV.Add(lnv);
                db.SaveChanges();
                return lnv;
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.ToString());
                return lnv;
            }
        }
        public tb_Luong_NV Update(tb_Luong_NV lnv)
        {
            try
            {
                var _lnv = db.tb_Luong_NV.FirstOrDefault(x => x.ID == lnv.ID);
                _lnv.MaNV = lnv.MaNV;
                _lnv.LCB = lnv.LCB;
                _lnv.ThoiGian = lnv.ThoiGian;
                _lnv.TrangThai = lnv.TrangThai;
                _lnv.Deleteby = lnv.Deleteby;
                db.SaveChanges();
                return lnv;
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
                var _tt = db.tb_Luong_NV.FirstOrDefault(x => x.ID == ID);
                _tt.Deleteby = tt;
                _tt.TrangThai = false;
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
