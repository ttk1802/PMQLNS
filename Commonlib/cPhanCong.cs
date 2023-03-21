using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Commonlib.join;

namespace Commonlib
{
   public class cPhanCong
    {
        QL_NSEntities db = new QL_NSEntities();
        public List<tb_PhanCong> getlist()
        {
            return db.tb_PhanCong.ToList();
        }

        public List<cPhanCongjoin> getlistfull()
        {
            var lstPC = db.tb_PhanCong.ToList();
            List<cPhanCongjoin> lstPCjoin = new List<cPhanCongjoin>();
            cPhanCongjoin pcj ;
            foreach (var item in lstPC)
            {
                pcj = new cPhanCongjoin();
                pcj.MaPC = item.MaPC;
                pcj.TenPC = item.TenPC;
                pcj.MaPB = item.MaPB;
                pcj.MaCV = item.MaCV;
                pcj.MaNV = item.MaNV;
                pcj.TrangThai = item.TrangThai;
                pcj.ThoiGian = item.ThoiGian;
                var pb = db.tb_PhongBan.FirstOrDefault(x=>x.MaPB == item.MaPB);
                pcj.TenPB = pb.TenPB;
                var cv = db.tb_ChucVu.FirstOrDefault(x => x.MaCV == item.MaCV);
                pcj.TenCV = cv.TenCV;
                var nv = db.NhanVien.FirstOrDefault(x => x.MaNV == item.MaNV);
                pcj.TenNV = nv.TenNV;
                lstPCjoin.Add(pcj);
            }
            return lstPCjoin;
        } 

        public tb_PhanCong getitem(int id)
        {
            return db.tb_PhanCong.FirstOrDefault(x => x.MaPC == id);
        }

        public tb_PhanCong UpdateItem(tb_PhanCong pc,string manv)
        {
            var lstPCItem =  db.tb_PhanCong.Where(x => x.MaNV == manv).ToList();
            
            foreach (var item in lstPCItem)
            {
                pc.TrangThai = item.TrangThai = false;
            }
            db.SaveChanges();
            return pc;
        }
        public tb_PhanCong Add(tb_PhanCong pc)
        {
            try
            {
                db.tb_PhanCong.Add(pc);
                db.SaveChanges();
                return pc;
            }
            catch (Exception ex)
            {

                throw new Exception("Error" + ex.ToString()); ;
            }
        }

        public tb_PhanCong Update(tb_PhanCong pc)
        {
            try
            {
                var _pc = db.tb_PhanCong.FirstOrDefault(x => x.MaPC == pc.MaPC);
                _pc.MaPB = pc.MaPB;
                _pc.MaCV = pc.MaCV;
                _pc.MaNV = pc.MaNV;
                _pc.TenPC = pc.TenPC;
                _pc.TrangThai = pc.TrangThai;
                _pc.ThoiGian = pc.ThoiGian;
                db.SaveChanges();
                return pc;
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
                var _pc = db.tb_PhanCong.FirstOrDefault(x => x.MaPC == id);
                db.tb_PhanCong.Remove(_pc);
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
