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
    public partial class FrmKTKL : DevExpress.XtraEditors.XtraForm
    {
        public FrmKTKL()
        {
            InitializeComponent();
        }
        cKTKL _cKTKL;
        cNhanVien _cnhanvien;
        int _id;
        static string strFormState;
        private void FrmKTKL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_NSDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qL_NSDataSet.NhanVien);
            _cKTKL = new cKTKL();
            _cnhanvien = new cNhanVien();
            LoadData();
            LoadNV();
            btnLuu.Enabled = false;
            btnDung.Enabled = false;
            splitContainer1.Panel1Collapsed = true;
            btnAnTT.Enabled = false;
        }
        void LoadData()
        {
            gcKTKL.DataSource = _cKTKL.getListfULL();
            gvKTKL.OptionsBehavior.Editable = false;

        }
        void LoadNV()
        {
            searchlookupeditNV.Properties.DataSource = _cnhanvien.getListfull();
            searchlookupeditNV.Properties.DisplayMember = "TenNV";
            searchlookupeditNV.Properties.ValueMember = "MaNV";
        }
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult warn = MessageBox.Show("Are you sure ?", "Warning!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (warn == DialogResult.Yes)
            {
                _cKTKL.Delete(_id, 1);
                LoadData();
            }
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

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
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
        int IDKTKL;
        void so()
        {
            string query = "select count(*) from tb_KhenThuong_KyLuat";
            ConnectSql.GetDataToTable1(query, "tb_KhenThuong_KyLuat");
            IDKTKL = int.Parse(ConnectSql.ds.Tables["tb_KhenThuong_KyLuat"].Rows[0][0].ToString()) + 1;
          

        }
        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (strFormState == "ADDING")
            {
                so();
                tb_KhenThuong_KyLuat  ktkl = new tb_KhenThuong_KyLuat();
                ktkl.SoTien = float.Parse(txtSoTien.Text);
                ktkl.SOKTKL = "KTKL/" + DateTime.Now.Year.ToString() + "//" + IDKTKL.ToString("D3"); 
                ktkl.MaNV = searchlookupeditNV.EditValue.ToString();
                ktkl.Ngay = int.Parse( txtNgay.Text);
                ktkl.Thang = int.Parse(txtThang.Text);
                ktkl.GhiChu = txtGhiChu.Text;
                ktkl.Loai = cbLoai.Text;
                _cKTKL.Add(ktkl);
                LoadData();
                btnDung.PerformClick();
            }
            if (strFormState == "EDITTING")
            {
                var ktkl = _cKTKL.getItem(_id);
                ktkl.SoTien = float.Parse(txtSoTien.Text);
                ktkl.MaNV = searchlookupeditNV.EditValue.ToString();
                ktkl.Ngay = int.Parse(txtNgay.Text);
                ktkl.Thang = int.Parse(txtThang.Text);
                ktkl.GhiChu = txtGhiChu.Text;
                ktkl.Loai = cbLoai.Text;
                _cKTKL.Update(ktkl);
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

        private void gvKTKL_Click(object sender, EventArgs e)
        {
            try
            {
                _id = int.Parse(gvKTKL.GetFocusedRowCellValue("ID").ToString());

            }
            catch (Exception)
            {

                return;
            }

            var ktkl =_cKTKL.getItem(_id);
            txtSoKTKL.Text = ktkl.SOKTKL;
            txtNgay.Text = ktkl.Ngay.ToString();
            txtThang.Text = ktkl.Thang.ToString();
            txtGhiChu.Text = ktkl.GhiChu;
            searchlookupeditNV.Text = ktkl.MaNV;
            txtSoTien.Text = ktkl.SoTien.ToString();
            cbLoai.Text = ktkl.Loai;
            splitContainer1.Panel1Collapsed = false;
            btnAnTT.Enabled = true;
        }

        private void gvKTKL_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {

            if (e.Column.Name == "Delete" && e.CellValue != null)
            {
                Image img = Properties.Resources.cancel_16x16;
                e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
                e.Handled = true;
            }
        }
    }
}