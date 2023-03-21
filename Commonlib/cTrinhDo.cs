using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
namespace Commonlib
{
    public class cTrinhDo
    {
        QL_NSEntities db = new QL_NSEntities();
        public List<tb_TrinhDo> getlist()
        {
            return db.tb_TrinhDo.ToList();
        }
        public tb_TrinhDo getitem(int id)
        {
            return db.tb_TrinhDo.FirstOrDefault(x => x.MaTD == id);
        }
        public tb_TrinhDo Add(tb_TrinhDo td)
        {
            try
            {
                db.tb_TrinhDo.Add(td);
                db.SaveChanges();
                return td;
            }
            catch (Exception ex)
            {

                throw new Exception("Error" + ex.ToString()); ;
            }
        }

        public tb_TrinhDo Update(tb_TrinhDo td)
        {
            try
            {
                var _td = db.tb_TrinhDo.FirstOrDefault(x => x.MaTD == td.MaTD);
                _td.TenTD = td.TenTD;
                db.SaveChanges();
                return td;
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
                var _td = db.tb_TrinhDo.FirstOrDefault(x => x.MaTD == id);
                db.tb_TrinhDo.Remove(_td);
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
