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
    public class cTangCa
    {
        QL_NSEntities db = new QL_NSEntities();

        public List<tb_TangCa> getList()
        {
            return db.tb_TangCa.ToList();
        }
        public List<tb_LoaiCa> getlistLC()
        {
            return db.tb_LoaiCa.ToList();
        }

        public List<cTangCajoin> getListfULL()
        {
            var lstTangCa = db.tb_TangCa.ToList();
            List<cTangCajoin> lsttcj = new List<cTangCajoin>();
            cTangCajoin tangcanvj;
            foreach (var item in lstTangCa)
            {
               tangcanvj = new cTangCajoin();
               tangcanvj.MaNV = item.MaNV;
               tangcanvj.ID = item.ID;
               tangcanvj.IDLoaiCa = item.IDLoaiCa;
               tangcanvj.SoGio = item.SoGio;
                tangcanvj.SoTien = item.SoTien;
                tangcanvj.thang = item.thang;
                tangcanvj.nam = item.nam;
                tangcanvj.TrangThai = item.TrangThai;
               tangcanvj.GhiChu = item.GhiChu;
               var NV = db.NhanVien.FirstOrDefault(x => x.MaNV == tangcanvj.MaNV);
               tangcanvj.TenNV = NV.TenNV;
               var LC = db.tb_LoaiCa.FirstOrDefault(x => x.IDLoaiCa == tangcanvj.IDLoaiCa);
               tangcanvj.TenLoaiCa = LC.TenLoaiCa;
               tangcanvj.HeSo = LC.HeSo;
               lsttcj.Add(tangcanvj);

            }
            return lsttcj;
        }
      
        public tb_TangCa getItem(int id)
        {
            return db.tb_TangCa.FirstOrDefault(x => x.ID == id);
        }

        public tb_LoaiCa getitemLC(int id)
        {
            return db.tb_LoaiCa.FirstOrDefault(x => x.IDLoaiCa == id);
        }

        public tb_TangCa Add(tb_TangCa tcnv)
        {
            try
            {
                db.tb_TangCa.Add(tcnv);
                db.SaveChanges();
                return tcnv;
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.ToString());
                return tcnv;
            }
        }
        public tb_TangCa Update(tb_TangCa tcnv)
        {
            try
            {
                var _tcnv = db.tb_TangCa.FirstOrDefault(x => x.ID == tcnv.ID);
                _tcnv.MaNV = tcnv.MaNV;
                _tcnv.thang = tcnv.thang;
                _tcnv.nam = tcnv.nam;
                _tcnv.SoTien = tcnv.SoTien;
                _tcnv.SoGio = tcnv.SoGio;
               _tcnv.TrangThai = tcnv.TrangThai;
               _tcnv.IDLoaiCa = tcnv.IDLoaiCa;
                _tcnv.GhiChu = tcnv.GhiChu;
                db.SaveChanges();
                return _tcnv;
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
                var _tt = db.tb_TangCa.FirstOrDefault(x => x.ID == ID);
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
