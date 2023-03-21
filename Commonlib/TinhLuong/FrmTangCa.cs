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


namespace Commonlib.TinhLuong
{
    public partial class FrmTangCa : DevExpress.XtraEditors.XtraForm
    {
        public FrmTangCa()
        {
            InitializeComponent();
        }
        cTangCa _ctangca;
        cNhanVien _cnhanvien;
        int _id;
        static string strFormState;
        private void FrmTangCa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_NSDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qL_NSDataSet.NhanVien);
            _ctangca = new cTangCa();
            _cnhanvien = new cNhanVien();
            LoadData();
            LoadNV();
            LoadPC();
            btnLuu.Enabled = false;
            btnDung.Enabled = false;
            splitContainer1.Panel1Collapsed = true;
            btnAnTT.Enabled = false;
            cbLC.SelectedIndexChanged += CbLC_SelectedIndexChanged;

        }

        private void CbLC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var tc = _ctangca.getitemLC(int.Parse(cbLC.SelectedValue.ToString()));
                if (tc != null)
                {
                    txtHeSo.Text = tc.HeSo.ToString();
                }
            }
            catch (Exception)
            {

                return;
            }
        }

        void LoadData()
        {
            gcTC.DataSource = _ctangca.getListfULL();
            gvLC.OptionsBehavior.Editable = false;

        }
        void LoadNV()
        {
            searchlookupeditNV.Properties.DataSource = _cnhanvien.getListfull();
            searchlookupeditNV.Properties.DisplayMember = "TenNV";
            searchlookupeditNV.Properties.ValueMember = "MaNV";
        }
        void LoadPC()
        {
            cbLC.DataSource = _ctangca.getlistLC();
            cbLC.DisplayMember = "TenLoaiCa";
            cbLC.ValueMember = "IDLoaiCa";
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
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult warn = MessageBox.Show("Are you sure ?", "Warning!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (warn == DialogResult.Yes)
            {
                _ctangca.Delete(_id, 0);
                LoadData();
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // txtTenpc.Focus();
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

                tb_TangCa tc = new tb_TangCa();
               tc.IDLoaiCa = Convert.ToInt32(cbLC.SelectedValue.ToString());
               tc.SoGio = float.Parse(txtSoGio.Text);
               tc.MaNV = searchlookupeditNV.EditValue.ToString();
               tc.nam =int.Parse( txtNam.Text);
                tc.thang = int.Parse(txtThang.Text);
                tc.GhiChu = txtGhiChu.Text;
                tc.SoTien = float.Parse(txtSoGio.Text) * float.Parse(txtHeSo.Text);
                _ctangca.Add(tc);
                LoadData();
                btnDung.PerformClick();
            }
            if (strFormState == "EDITTING")
            {
                var tc = _ctangca.getItem(_id);
                tc.IDLoaiCa = Convert.ToInt32(cbLC.SelectedValue.ToString());
                tc.SoGio = float.Parse(txtSoGio.Text);
                tc.MaNV = searchlookupeditNV.EditValue.ToString();
                tc.nam = int.Parse(txtNam.Text);
                tc.thang = int.Parse(txtThang.Text);
                tc.GhiChu = txtGhiChu.Text;
                tc.SoTien = float.Parse(txtSoGio.Text) * float.Parse(txtHeSo.Text);
                _ctangca.Update(tc);
                LoadData();
                btnDung.PerformClick();
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

        private void gvLC_Click(object sender, EventArgs e)
        {
            try
            {
                _id = int.Parse(gvLC.GetFocusedRowCellValue("ID").ToString());

            }
            catch (Exception)
            {

                return;
            }

            var tc = _ctangca.getItem(_id);
            txtThang.Text = tc.thang.ToString();
            txtNam.Text = tc.nam.ToString();
            txtSoGio.Text = tc.SoGio.ToString();
            txtGhiChu.Text = tc.GhiChu;
            cbLC.SelectedValue = tc.IDLoaiCa;
            searchlookupeditNV.EditValue = tc.MaNV;
            splitContainer1.Panel1Collapsed = false;
            btnAnTT.Enabled = true;
        }

        private void gvLC_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "delete" && e.CellValue != null)
            {
                Image img = Properties.Resources.cancel_16x16;
                e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
                e.Handled = true;
            }
        }
    }
}