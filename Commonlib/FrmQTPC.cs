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
    public partial class FrmQTPC : DevExpress.XtraEditors.XtraForm
    {
        public FrmQTPC()
        {
            InitializeComponent();
        }
        cNhanVien _nhanvien;
        private void FrmQTPC_Load(object sender, EventArgs e)
        {
            _nhanvien = new cNhanVien();
            LoadData();
        }
        void LoadData()
        {
            gcPC.DataSource = _nhanvien.getlistPhanCong(FrmNhanVien.idnv);
            gvPC.OptionsBehavior.Editable = false;
        }
    }
}