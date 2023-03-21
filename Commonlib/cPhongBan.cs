using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
namespace Commonlib
{
   public class cPhongBan
    {
        QL_NSEntities db = new QL_NSEntities();
        public List<tb_PhongBan> getlist()
        {
            return db.tb_PhongBan.ToList();
        }
        
        public tb_PhongBan getitem(int id)
        {
            return db.tb_PhongBan.FirstOrDefault(x=>x.MaPB == id);
        }
        public tb_PhongBan Add(tb_PhongBan pb)
        {
            try
            {
                db.tb_PhongBan.Add(pb);
                db.SaveChanges();
                return pb;
            }
            catch (Exception ex)
            {

                throw new Exception("Error" + ex.ToString()); ;
            }
        }

        public tb_PhongBan Update(tb_PhongBan pb)
        {
            try
            {
                var _pb = db.tb_PhongBan.FirstOrDefault(x => x.MaPB == pb.MaPB);
                _pb.TenPB = pb.TenPB;
                _pb.DiaChi = pb.DiaChi;
                _pb.DienThoai = pb.DienThoai;
                db.SaveChanges();
                return pb;
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
                var _pb = db.tb_PhongBan.FirstOrDefault(x => x.MaPB==id);
                db.tb_PhongBan.Remove(_pb);
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
