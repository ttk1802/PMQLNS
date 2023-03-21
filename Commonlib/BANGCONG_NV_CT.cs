using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
namespace Commonlib
{
   public class BANGCONG_NV_CT
    {
        QL_NSEntities db = new QL_NSEntities();
        public BANGCONG_NHANVIEN_CHITIET Add(BANGCONG_NHANVIEN_CHITIET bcct)
        {
            try
            {
                db.BANGCONG_NHANVIEN_CHITIET.Add(bcct);
                db.SaveChanges();
                return bcct;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public BANGCONG_NHANVIEN_CHITIET GetItem(int makycong, string manv, int ngay)
        {
            return db.BANGCONG_NHANVIEN_CHITIET.FirstOrDefault(x=>x.MAKYCONG==makycong && x.MANV==manv && x.NGAY.Value.Day == ngay);
        }


        public BANGCONG_NHANVIEN_CHITIET Update(BANGCONG_NHANVIEN_CHITIET bcct)
        {
            try
            {
                BANGCONG_NHANVIEN_CHITIET bcnv = db.BANGCONG_NHANVIEN_CHITIET.FirstOrDefault(x=>x.MAKYCONG==bcct.MAKYCONG && x.MANV==bcct.MANV && x.NGAY==bcct.NGAY);
                bcnv.KYHIEU = bcct.KYHIEU;
                bcnv.GIOVAO = bcct.GIOVAO;
                bcnv.GIORA = bcct.GIORA;
                bcnv.HOTEN = bcct.HOTEN;
                bcnv.NgayCong = bcct.NgayCong;
                bcnv.GHICHU = bcct.GHICHU;
                bcnv.NGAYPHEP = bcct.NGAYPHEP;
                bcnv.CONGNGAYLE = bcct.CONGNGAYLE;
                db.SaveChanges();
                return bcnv;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public double fc_TongNgayPhep( int makycong, string manv)
        {
            return db.BANGCONG_NHANVIEN_CHITIET.Where(x=>x.MAKYCONG==makycong && x.MANV==manv && x.NGAYPHEP!=null).ToList().Sum(p=>p.NGAYPHEP.Value);
        }
        public double fc_TongNgayCong(int makycong, string manv)
        {
            return db.BANGCONG_NHANVIEN_CHITIET.Where(x => x.MAKYCONG == makycong && x.MANV == manv && x.NgayCong != null).ToList().Sum(p => p.NgayCong.Value);
        }
      

        public double fc_TongNgayLe(int makycong, string manv)
        {
            return db.BANGCONG_NHANVIEN_CHITIET.Where(x => x.MAKYCONG == makycong && x.MANV == manv && x.CONGNGAYLE != null).ToList().Sum(p => p.CONGNGAYLE.Value);
        }
    
        public double fc_TongNgayCN(int makycong, string manv)
        {
            return db.BANGCONG_NHANVIEN_CHITIET.Where(x => x.MAKYCONG == makycong && x.MANV == manv && x.CONGCHUNHAT != null).ToList().Sum(p => p.CONGCHUNHAT.Value);
        }
    }
}
