using System.Collections.Generic;
using System.Linq;
using Data;
namespace Commonlib
{
    public class KCONG
    {
        QL_NSEntities db = new QL_NSEntities();
        public KYCONG getItem(int id)
        {
            return db.KYCONG.FirstOrDefault(x=>x.MAKYCONG==id);
        }
        public List<KYCONG> getList()
        {
            return db.KYCONG.ToList();
        }


        public KYCONG Update(KYCONG kc)
        {
            try
            {
                var _kc = db.KYCONG.FirstOrDefault(x => x.MAKYCONG == kc.MAKYCONG);
                _kc.TRANGTHAI = kc.TRANGTHAI;
                db.SaveChanges();
                return kc;

            }
            catch (System.Exception)
            {

                throw;
            }
            return kc;
        }

        public bool KiemTraPhatSinhKyCong(int makycong)
        {
            var kc = db.KYCONG.FirstOrDefault(x => x.MAKYCONG == makycong);
            if (kc==null)
            {
                    return false;
            }
            else
            {
                if (kc.TRANGTHAI == true)
                {
                    return true;
                }
                else
                    return false;
            }
        }
    }
}
