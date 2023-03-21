using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Commonlib.join;

namespace Commonlib
{
   public class cUngLuong
    {
        QL_NSEntities db = new QL_NSEntities();

        public tb_UngLuong getItem(int id)
        {
            return db.tb_UngLuong.FirstOrDefault(x => x.ID == id);
        }

        public List<cUngLuongjoin> getlistFull()
        {
            var lst = db.tb_UngLuong.ToList();
            List<cUngLuongjoin> lstjul = new List<cUngLuongjoin>();
            cUngLuongjoin ulj;
            foreach (var item in lst)
            {
                ulj = new cUngLuongjoin();
                ulj.ID = item.ID;
                ulj.Ngay = item.Ngay;
                ulj.Thang = item.Thang;
                ulj.Nam = item.Nam;
                ulj.MaNV = item.MaNV;
                var nv = db.NhanVien.FirstOrDefault(x => x.MaNV == item.MaNV);
                ulj.TenNV = nv.TenNV;
                ulj.SoTien = item.SoTien;
                ulj.GhiChu = item.GhiChu;
                ulj.TrangThai = item.TrangThai;
                lstjul.Add(ulj);

            }
            return lstjul;
        }

        public tb_UngLuong Add(tb_UngLuong ul)
        {
            try
            {
                db.tb_UngLuong.Add(ul);
                db.SaveChanges();
                return ul;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public tb_UngLuong Update(tb_UngLuong ul)
        {
            try
            {
                var _ul = db.tb_UngLuong.FirstOrDefault(x => x.ID == ul.ID);
                _ul.Ngay = ul.Ngay;
                _ul.Thang = ul.Thang;
                _ul.Nam = ul.Nam;
                _ul.MaNV = ul.MaNV;
                _ul.SoTien = ul.SoTien;
                _ul.GhiChu = ul.GhiChu;
                db.SaveChanges();
                return ul;

            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Delete(int id, int status)
        {
            try
            {
                var ul = db.tb_UngLuong.FirstOrDefault(x => x.ID == id);
                ul.TrangThai = status;
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
