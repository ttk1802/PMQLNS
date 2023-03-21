using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using System.Windows.Forms;

namespace Commonlib
{
   public class cBangLuong
    {

        QL_NSEntities db = new QL_NSEntities();

        public List<tb_BangLuong> getList(int MaKC)
        {
            return db.tb_BangLuong.Where(x => x.MAKYCONG == MaKC).ToList();
        }

        public void TinhLuongNV(int MaKC)
        {
            double luongtheogio, luongngaythuong, luongngayphep, luongtangca, luongchunhat, luongngayle, phucap, ungluong, bhyt, bhxh, bhtn, thuclanh;
            var listNV = db.NhanVien.Where(x => x.DangLamViec == null).ToList();
            foreach (var item in listNV)
            {
                
                var kcct = db.KYCONGCHITIET.FirstOrDefault(x => x.MAKYCONG == MaKC && x.MANV == item.MaNV);
                var luongcb = db.tb_Luong_NV.FirstOrDefault(x => x.MaNV == item.MaNV && x.TrangThai == true);
                //Luong 1 ngay
                if (kcct==null)
                {
                    MessageBox.Show("Chưa có kỳ công");
                    return;
                }
                else
                {

              
                var luongngaycong = luongcb.LCB / kcct.NGAYCONG;
                //Luong các ngay cong 
                luongngaythuong = Convert.ToDouble(luongngaycong * kcct.TONGNGAYCONG);

                //Luong theo gio
                luongtheogio = luongngaythuong / 8;
                //Luong các ngay phep 
                luongngayphep =  Convert.ToDouble(luongngaycong * kcct.NGAYPHEP * 0.3);
                //Luong chu nhat
                luongchunhat = Convert.ToDouble(luongngaycong * 2 * kcct.CONGCHUNHAT);
                //Luong ngay le 
                luongngayle = Convert.ToDouble(luongngaycong * 2.5 * kcct.CONGNGAYLE);
                //Luong tang ca
                luongtangca = Convert.ToDouble(db.tb_TangCa.Where(x=>(x.nam*100+x.thang) == MaKC && x.MaNV  == item.MaNV).Sum(x=>x.SoTien * luongtheogio));
                //Phu Cap 
                phucap = Convert.ToDouble(db.tb_PhuCap_NhanVien.Where(x =>x.MaNV == item.MaNV).Sum(x => x.SoTien));
                //Ung Luong 
                ungluong = Convert.ToDouble(db.tb_UngLuong.Where(x => (x.Nam * 100 + x.Thang) == MaKC && x.MaNV == item.MaNV).Sum(x => x.SoTien));
                //Bảo hiểm 
                bhyt = Convert.ToDouble(luongcb.LCB * 1.5 / 100);
                bhxh = Convert.ToDouble(luongcb.LCB * 8 / 100);
                bhtn = Convert.ToDouble(luongcb.LCB * 1 / 100);
                //Thực lãnh
                thuclanh = luongngaythuong + luongngayphep + luongchunhat + luongngayle + luongtangca + phucap - (ungluong + bhyt + bhxh + bhtn);

                tb_BangLuong bl = new tb_BangLuong();
                bl.MAKYCONG = MaKC;
                bl.MaNV = item.MaNV;
                bl.TenNV = item.TenNV;
                bl.NgayCongTrongThang = int.Parse(kcct.NGAYCONG.ToString());
                bl.NgayPhep = luongngayphep;
                bl.NgayChuNhat = luongchunhat;
                bl.NgayLe = luongngayle;
                bl.NgayThuong = luongngaythuong;
                bl.PhuCap = phucap;
                bl.TangCa = luongtangca;
                bl.UngLuong = ungluong;
                bl.BHYT = bhyt;
                bl.BHXH = bhxh;
                bl.BHTN = bhtn;
                bl.ThucLanh = thuclanh;
                    bl.TrangThai = true;
                Add(bl);
                }

            }
        }
        public bool KiemTraPhatBangLuong(int makycong)
        {
            var kc = db.tb_BangLuong.FirstOrDefault(x => x.MAKYCONG == makycong);
            if (kc == null)
            {
                return false;
            }
            else
            {
                if (kc.TrangThai == true)
                {
                    return true;
                }
                else
                    return false;
            }
        }
        public tb_BangLuong getitem(int MaKC, string MaNV)
        {
            return db.tb_BangLuong.FirstOrDefault(x => x.MAKYCONG == MaKC && x.MaNV==MaNV);
        }
        public tb_BangLuong Add(tb_BangLuong bl)
        {
            try
            {
                db.tb_BangLuong.Add(bl);
                db.SaveChanges();
                return bl;
            }
            catch (Exception ex)
            {

                throw new Exception("Error" + ex.ToString()); ;
            }
        }

        public tb_BangLuong Update(tb_BangLuong bl)
        {
            try
            {
                tb_BangLuong _bl = db.tb_BangLuong.FirstOrDefault(x => x.MAKYCONG == bl.MAKYCONG && x.MaNV==bl.MaNV);
                _bl.MaNV = bl.MaNV;
                _bl.MAKYCONG = bl.MAKYCONG;
                _bl.TenNV = bl.TenNV;
                _bl.NgayPhep = bl.NgayPhep;
                _bl.KhongPhep = bl.KhongPhep;
                _bl.NgayPhep = bl.NgayPhep;
                _bl.NgayChuNhat = bl.NgayChuNhat;
                _bl.NgayThuong = bl.NgayThuong;
                _bl.TangCa = bl.TangCa;
                _bl.PhuCap = bl.PhuCap;
                _bl.UngLuong = bl.UngLuong;
                _bl.BHTN = bl.BHTN;
                _bl.BHXH = bl.BHXH;
                _bl.BHYT = bl.BHYT;
                _bl.ThucLanh = bl.ThucLanh;
                db.SaveChanges();
                return bl;
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
                var _bl = db.tb_BangLuong.FirstOrDefault(x => x.ID == id);
                db.tb_BangLuong.Remove(_bl);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
    }
}
