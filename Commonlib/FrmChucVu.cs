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
    public partial class FrmChucVu : DevExpress.XtraEditors.XtraForm
    {
        public FrmChucVu()
        {
            InitializeComponent();
        }
        cChucVu _cchucVu;
        int _id;
        static string strFormState;
        private void FrmChucVu_Load(object sender, EventArgs e)
        {
            _cchucVu = new cChucVu();
            LoadData();
            btnLuu.Enabled = false;
            btnDung.Enabled = false;
            splitContainer1.Panel1Collapsed = true;
            btnAnTT.Enabled = false;
        }
        void LoadData()
        {
            gcCV.DataSource = _cchucVu.getlist();
            gvCV.OptionsBehavior.Editable = false;
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ConnectSql.XoaNoiDung(groupControl1);
            splitContainer1.Panel1Collapsed = false;
            btnThoat.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            strFormState = "ADDING";

            btnLuu.Enabled = true;
            btnDung.Enabled = true;
            btnAnTT.Enabled = false;

            txtTenCV.Focus();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult warn = MessageBox.Show("Are you sure ?", "Warning!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (warn == DialogResult.Yes)
            {
                _cchucVu.Delete(_id);
                LoadData();
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtTenCV.Focus();
            splitContainer1.Panel1Collapsed = false;
            btnThoat.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            strFormState = "EDITTING";

            btnLuu.Enabled = true;
            btnDung.Enabled = true;
            btnAnTT.Enabled = false;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (strFormState == "ADDING")
            {
                tb_ChucVu cv = new tb_ChucVu();
                cv.TenCV = txtTenCV.Text;
                _cchucVu.Add(cv);
                LoadData();
                btnDung.PerformClick();
                ConnectSql.XoaNoiDung(groupControl1);
            }
            if (strFormState == "EDITTING")
            {
                var cv = _cchucVu.getitem(_id);
                cv.TenCV = txtTenCV.Text;
                _cchucVu.Update(cv);
                LoadData();
                btnDung.PerformClick();
                ConnectSql.XoaNoiDung(groupControl1);

            }
        }

        private void btnDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnLuu.Enabled = false;
            btnThoat.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnDung.Enabled = false;
            btnAnTT.Enabled = true;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnAnTT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            splitContainer1.Panel1Collapsed = true;
            btnAnTT.Enabled = false;
        }

        private void gvCV_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvCV.GetFocusedRowCellValue("MaCV").ToString());
            txtTenCV.Text = gvCV.GetFocusedRowCellValue("TenCV").ToString();
            splitContainer1.Panel1Collapsed = false;
            btnAnTT.Enabled = true;
        }
    }
}