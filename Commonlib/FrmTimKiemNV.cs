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
using Data;

namespace Commonlib
{
    public partial class FrmTimKiemNV : DevExpress.XtraEditors.XtraForm
    {
        public FrmTimKiemNV()
        {
            InitializeComponent();
        }
        cNhanVien _cNhanVien;
        private void FrmTimKiemNV_Load(object sender, EventArgs e)
        {
            _cNhanVien = new cNhanVien();
            LoadData();
        }
        void LoadData()
        {
            gcNV.DataSource = _cNhanVien.getList();
            gvNV.OptionsBehavior.Editable = false;
        }
        string _id;
        
        private void gvNV_Click(object sender, EventArgs e)
        {
            try
            {
                _id = gvNV.GetFocusedRowCellValue("MaNV").ToString();
            }
            catch (Exception)
            {

                return;
            }


            var nv = _cNhanVien.getitem(_id);
         /*   FrmPhanCong.fMaNV = nv.MaNV;
            FrmPhanCong.fTenNV = nv.TenNV;*/
            Close();

        }
    }
}