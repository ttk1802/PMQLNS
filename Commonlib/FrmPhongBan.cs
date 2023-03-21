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
    public partial class FrmPhongBan : DevExpress.XtraEditors.XtraForm
    {
        public FrmPhongBan()
        {
            InitializeComponent();
        }
        cPhongBan _cphongban;
        int _id;
        static string strFormState;
        private void FrmPhongBan_Load(object sender, EventArgs e)
        {
            _cphongban = new cPhongBan();
            LoadData();
            btnLuu.Enabled = false;
            btnDung.Enabled = false;
            splitContainer1.Panel1Collapsed = true;
            btnAnTT.Enabled = false;
        }
        void LoadData()
        {
            gcPB.DataSource = _cphongban.getlist();
            gvPB.OptionsBehavior.Editable = false;
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

            txtTenPB.Focus();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult warn = MessageBox.Show("Are you sure ?", "Warning!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (warn == DialogResult.Yes)
            {
                _cphongban.Delete(_id);
                LoadData();
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtTenPB.Focus();
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
                tb_PhongBan pb = new tb_PhongBan();
                pb.TenPB = txtTenPB.Text;
                pb.DiaChi = txtDiaChi.Text;
                pb.DienThoai = txtDT.Text;
                _cphongban.Add(pb);
                LoadData();
                btnDung.PerformClick();
                ConnectSql.XoaNoiDung(groupControl1);
            }
            if (strFormState == "EDITTING")
            {
                var pb = _cphongban.getitem(_id);
                pb.TenPB = txtTenPB.Text;
                pb.DiaChi = txtDiaChi.Text;
                pb.DienThoai = txtDT.Text;
                _cphongban.Update(pb);
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

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnAnTT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splitContainer1.Panel1Collapsed = true;
            btnAnTT.Enabled = false;
        }

        private void gvPB_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvPB.GetFocusedRowCellValue("MaPB").ToString());
            txtTenPB.Text = gvPB.GetFocusedRowCellValue("TenPB").ToString();
            txtDiaChi.Text = gvPB.GetFocusedRowCellValue("DiaChi").ToString();
            txtDT.Text = gvPB.GetFocusedRowCellValue("DienThoai").ToString();
            splitContainer1.Panel1Collapsed = false;
            btnAnTT.Enabled = true;
        }
    }
}