using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
namespace Commonlib
{
  public  class cChucVu
    {
        QL_NSEntities db = new QL_NSEntities();
        public List<tb_ChucVu> getlist()
        {
            return db.tb_ChucVu.ToList();
        }
        public tb_ChucVu getitem(int id)
        {
            return db.tb_ChucVu.FirstOrDefault(x => x.MaCV == id);
        }
        public tb_ChucVu Add(tb_ChucVu cv)
        {
            try
            {
                db.tb_ChucVu.Add(cv);
                db.SaveChanges();
                return cv;
            }
            catch (Exception ex)
            {

                throw new Exception("Error" + ex.ToString()); ;
            }
        }

        public tb_ChucVu Update(tb_ChucVu cv)
        {
            try
            {
                var _cv = db.tb_ChucVu.FirstOrDefault(x => x.MaCV == cv.MaCV);
                _cv.TenCV = cv.TenCV;
                db.SaveChanges();
                return cv;
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
                var _cv = db.tb_ChucVu.FirstOrDefault(x => x.MaCV == id);
                db.tb_ChucVu.Remove(_cv);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
               MessageBox.Show("Error" + ex.Message);
            }
        }
    }
}
