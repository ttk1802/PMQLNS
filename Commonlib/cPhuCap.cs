using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Commonlib.join;

namespace Commonlib
{
   public class cPhuCap
    {
        QL_NSEntities db = new QL_NSEntities();
        public List<tb_PhuCap_NhanVien> getlist()
        {
            return db.tb_PhuCap_NhanVien.ToList();
        }

        public List<cPhuCapjoin> getlistfull()
        {
            var lstNVPC = db.tb_PhuCap_NhanVien.ToList();
            List<cPhuCapjoin> lstphucapjoin = new List<cPhuCapjoin>();
            cPhuCapjoin pcnvj;
            cNhanVien _nhanvien = new cNhanVien();
            foreach (var item in lstNVPC)
            {
                pcnvj = new cPhuCapjoin();
                pcnvj.ID = item.ID;
                pcnvj.MaNV = item.MaNV;
                var nv = _nhanvien.getItemfull(item.MaNV);
                pcnvj.TenNV = nv.TenNV;
                pcnvj.MaPCap = item.MaPCap;
                var pc = db.tb_PhuCap.FirstOrDefault(x=>x.MaPCap==item.MaPCap);
                pcnvj.TenPCap = pc.TenPCap;
                pcnvj.NoiDung = item.NoiDung;
                pcnvj.Ngay = item.Ngay;
                pcnvj.SoTien = item.SoTien;
                pcnvj.Delete_by = item.Delete_by;
                lstphucapjoin.Add(pcnvj);
            }
            return lstphucapjoin;
        }

        public tb_PhuCap_NhanVien getitem(int id)
        {
            return db.tb_PhuCap_NhanVien.FirstOrDefault(x => x.ID == id);
        }

        public List<tb_PhuCap> getlistPC()
        {
            return db.tb_PhuCap.ToList();
        }

        public tb_PhuCap getitemPC(int id)
        {
            return db.tb_PhuCap.FirstOrDefault(x => x.MaPCap == id);
        }
        public tb_PhuCap_NhanVien Add(tb_PhuCap_NhanVien pc)
        {
            try
            {
                db.tb_PhuCap_NhanVien.Add(pc);
                db.SaveChanges();
                return pc;
            }
            catch (Exception ex)
            {

                throw new Exception("Error" + ex.ToString()); ;
            }
        }

        public tb_PhuCap_NhanVien Update(tb_PhuCap_NhanVien pc)
        {
            try
            {
                var _pc = db.tb_PhuCap_NhanVien.FirstOrDefault(x => x.ID == pc.ID);
                _pc.MaNV = pc.MaNV;
                _pc.MaPCap = pc.MaPCap;
                _pc.Ngay = pc.Ngay;
                _pc.NoiDung = pc.NoiDung;
                _pc.SoTien = pc.SoTien;
                db.SaveChanges();
                return pc;
            }
            catch (Exception ex)
            {

                throw new Exception("Error" + ex.ToString()); ;
            }
        }
        public void Delete(int id, int status)
        {
            try
            {
                var _pc = db.tb_PhuCap_NhanVien.FirstOrDefault(x => x.ID == id);
                _pc.Delete_by = status;
               // db.tb_PhuCap_NhanVien.Remove(_pc);
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
