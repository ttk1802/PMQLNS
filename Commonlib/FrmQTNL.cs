using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Commonlib
{
    public partial class FrmQTNL : DevExpress.XtraEditors.XtraForm
    {
        public FrmQTNL()
        {
            InitializeComponent();
        }
        cNhanVien _nhanvien;
        private void FrmQTNL_Load(object sender, EventArgs e)
        {
            _nhanvien = new cNhanVien();
            LoadData();
        }
        void LoadData()
        {
            gcLnv.DataSource = _nhanvien.getListLuong(FrmNhanVien.idnv);
            gvLnv.OptionsBehavior.Editable = false;
        }
    }
}