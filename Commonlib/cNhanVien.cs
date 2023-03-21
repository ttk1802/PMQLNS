using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Commonlib.join;

namespace Commonlib
{
   public class cNhanVien
    {
        QL_NSEntities db = new QL_NSEntities();
        public List<NhanVien> getList()
        {
            return db.NhanVien.ToList();
        }

        public List<cNhanVienjoin> getListfull()
        {
            var rs = from NV in db.NhanVien
                     where NV.DangLamViec != 0
                     select NV;
            var lstNhanVien = rs.ToList();
            List<cNhanVienjoin> lstnvj = new List<cNhanVienjoin>();
            cNhanVienjoin nvj;
            foreach (var item in lstNhanVien)
            {
                nvj = new cNhanVienjoin();
                nvj.MaNV = item.MaNV;
                nvj.TenNV = item.TenNV;
                nvj.GioiTinh = item.GioiTinh;
                nvj.NgaySinh = item.NgaySinh;
                nvj.SDT = item.SDT;
                nvj.CCCD = item.CCCD;
                nvj.HinhAnh = item.HinhAnh;
                nvj.DiaChi = item.DiaChi;
                nvj.MaTD = item.MaTD;
                nvj.DangLamViec = item.DangLamViec;
                var td = db.tb_TrinhDo.FirstOrDefault(x => x.MaTD == nvj.MaTD);
                nvj.TenTD = td.TenTD;
             
              
                lstnvj.Add(nvj);

            }
            return lstnvj;
        }
        public List<cNhanVienjoin> getListfull_All()
        {
        
            var lstNhanVien = db.NhanVien.ToList();
            List<cNhanVienjoin> lstnvj = new List<cNhanVienjoin>();
            cNhanVienjoin nvj;
            foreach (var item in lstNhanVien)
            {
                nvj = new cNhanVienjoin();
                nvj.MaNV = item.MaNV;
                nvj.TenNV = item.TenNV;
                nvj.GioiTinh = item.GioiTinh;
                nvj.NgaySinh = item.NgaySinh;
                nvj.SDT = item.SDT;
                nvj.CCCD = item.CCCD;
                nvj.HinhAnh = item.HinhAnh;
                nvj.DiaChi = item.DiaChi;
                nvj.MaTD = item.MaTD;
                nvj.DangLamViec = item.DangLamViec;
                var td = db.tb_TrinhDo.FirstOrDefault(x => x.MaTD == nvj.MaTD);
                nvj.TenTD = td.TenTD;
                var pc = db.tb_PhanCong.FirstOrDefault(x => x.MaNV == nvj.MaNV);
                if (pc != null)
                {
                    nvj.TenPC = pc.TenPC;
                }
                lstnvj.Add(nvj);

            }
            return lstnvj;
        }
        public List<cNhanVienjoin> getListfull_TinhLuong()
        {

            var rs = from NV in db.NhanVien
                     where NV.DangLamViec != 0
                     select NV;
            var lstNhanVien = rs.ToList();
            List<cNhanVienjoin> lstnvj = new List<cNhanVienjoin>();
            cNhanVienjoin nvj;
            foreach (var item in lstNhanVien)
            {
                nvj = new cNhanVienjoin();
                nvj.MaNV = item.MaNV;
                nvj.TenNV = item.TenNV;
                nvj.GioiTinh = item.GioiTinh;
                nvj.NgaySinh = item.NgaySinh;
                nvj.SDT = item.SDT;
                nvj.CCCD = item.CCCD;
                nvj.HinhAnh = item.HinhAnh;
                nvj.DiaChi = item.DiaChi;
                nvj.MaTD = item.MaTD;
                nvj.DangLamViec = item.DangLamViec;
                var td = db.tb_TrinhDo.FirstOrDefault(x => x.MaTD == nvj.MaTD);
                nvj.TenTD = td.TenTD;
              
                var pc = db.tb_PhanCong.FirstOrDefault(x => x.MaNV == nvj.MaNV);
                if (pc != null)
                {
                    nvj.TenPC = pc.TenPC;
                }
                lstnvj.Add(nvj);

            }
            return lstnvj;
        }



        public cNhanVienjoin getItemfull(string id)
        {
            var item = db.NhanVien.FirstOrDefault(x=>x.MaNV==id);
           
            cNhanVienjoin nvj = new cNhanVienjoin();
                nvj.MaNV = item.MaNV;
                nvj.TenNV = item.TenNV;
                nvj.GioiTinh = item.GioiTinh;
                nvj.NgaySinh = item.NgaySinh;
                nvj.SDT = item.SDT;
                nvj.CCCD = item.CCCD;
                nvj.HinhAnh = item.HinhAnh;
                nvj.DiaChi = item.DiaChi;
                nvj.MaTD = item.MaTD;
                var td = db.tb_TrinhDo.FirstOrDefault(x => x.MaTD == nvj.MaTD);
                nvj.TenTD = td.TenTD;
            return nvj;
        }
        public NhanVien getitem(String id)
        {
            return db.NhanVien.FirstOrDefault(x => x.MaNV == id);
        }
        public NhanVien Add(NhanVien nv)
        {
            try
            {
                db.NhanVien.Add(nv);
                db.SaveChanges();
                return nv;
            }
            catch (Exception ex)
            {

                throw new Exception("Error" + ex.ToString()); ;
            }
        }

        public NhanVien Update(NhanVien nv)
        {
            try
            {
                var _nv = db.NhanVien.FirstOrDefault(x => x.MaNV == nv.MaNV);
                _nv.TenNV = nv.TenNV;
                _nv.GioiTinh = nv.GioiTinh;
                _nv.NgaySinh = nv.NgaySinh;
                _nv.SDT = nv.SDT;
                _nv.DiaChi = nv.DiaChi;
                _nv.CCCD = nv.CCCD;
                _nv.HinhAnh = nv.HinhAnh;
                _nv.MaTD = nv.MaTD;
               // _nv.DaThoiViec = nv.DaThoiViec;
                db.SaveChanges();
                return nv;
            }
            catch (Exception ex)
            {

                throw new Exception("Error" + ex.ToString()); ;
            }
        }
        public void Delete(string id, int tt)
        {
            try
            {
                var _nv = db.NhanVien.FirstOrDefault(x => x.MaNV == id);
                _nv.DangLamViec = tt;
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }


        public List<cLuongNVjoin> getListLuong(string manv)
        {
            var lstLuongNV = db.tb_Luong_NV.Where(x=>x.MaNV == manv).ToList();
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
        public List<cPhanCongjoin> getlistPhanCong(string manv)
        {
            var lstPC = db.tb_PhanCong.Where(x=>x.MaNV == manv).ToList();
            List<cPhanCongjoin> lstPCjoin = new List<cPhanCongjoin>();
            cPhanCongjoin pcj;
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
                var pb = db.tb_PhongBan.FirstOrDefault(x => x.MaPB == item.MaPB);
                pcj.TenPB = pb.TenPB;
                var cv = db.tb_ChucVu.FirstOrDefault(x => x.MaCV == item.MaCV);
                pcj.TenCV = cv.TenCV;
                var nv = db.NhanVien.FirstOrDefault(x => x.MaNV == item.MaNV);
                pcj.TenNV = nv.TenNV;
                lstPCjoin.Add(pcj);
            }
            return lstPCjoin;
        }


    }
}
