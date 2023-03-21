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
    public partial class FrmLuongNV : DevExpress.XtraEditors.XtraForm
    {
        public FrmLuongNV()
        {
            InitializeComponent();
        }
        cLuongNV c_luongnv;
        cNhanVien _nhanvien;
      
        int _id;

        static string strFormState;
        private void FrmLuongNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_NSDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qL_NSDataSet.NhanVien);
            c_luongnv = new cLuongNV();
            _nhanvien = new cNhanVien();
            LoadData();
            LoadNV();
            txtMaNV.Text = FrmNhanVien.idnv;
            btnLuu.Enabled = false;
            btnDung.Enabled = false;
            //splitContainer1.Panel1Collapsed = true;
            btnAnTT.Enabled = false;
            
        }
        void LoadData()
        {
            gcLnv.DataSource = c_luongnv.getListfULL();
            gvLnv.OptionsBehavior.Editable = false;
        }
        void LoadNV()
        {
            txtMaNV.Properties.DataSource = _nhanvien.getListfull_TinhLuong();
            txtMaNV.Properties.DisplayMember = "TenNV";
            txtMaNV.Properties.ValueMember = "MaNV";
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
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
                c_luongnv.Delete(_id, 1);
                LoadData();
            }
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

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (strFormState == "ADDING")
            {
                tb_Luong_NV t_lnv = new tb_Luong_NV();
                c_luongnv.UpdateItem(t_lnv, txtMaNV.EditValue.ToString());
                t_lnv.ThoiGian = dtpTG.Value;
                t_lnv.MaNV = txtMaNV.EditValue.ToString();
                t_lnv.LCB = double.Parse(txtLuongCB.Text);
                t_lnv.TrangThai = true;
                c_luongnv.Add(t_lnv);
                LoadData();
                btnDung.PerformClick();
                ConnectSql.XoaNoiDung(groupControl1);
               
            }
            if (strFormState == "EDITTING")
            {
                tb_Luong_NV luong_old = new tb_Luong_NV();
                c_luongnv.UpdateItem(luong_old, txtMaNV.EditValue.ToString());
                var lnv = c_luongnv.getItem(_id);
                lnv.ThoiGian = dtpTG.Value;
                lnv.LCB = double.Parse(txtLuongCB.Text);
                lnv.TrangThai = true;
                c_luongnv.Update(lnv);
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
            Close();
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnAnTT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splitContainer1.Panel1Collapsed = true;
            btnAnTT.Enabled = false;
        }

        private void gvLnv_Click(object sender, EventArgs e)
        {
            try
            {
                _id = int.Parse(gvLnv.GetFocusedRowCellValue("ID").ToString());

            }
            catch (Exception)
            {

                return;
            }

            var ttnv = c_luongnv.getItem(_id);
            // MessageBox.Show(pc.ToString());
            dtpTG.Value = DateTime.Parse(ttnv.ThoiGian.ToString());
            
            txtLuongCB.Text = ttnv.LCB.ToString();
            txtMaNV.Text = ttnv.MaNV;
            cbTrangThai.Checked = ttnv.TrangThai.Value;
            splitContainer1.Panel1Collapsed = false;
            btnAnTT.Enabled = true;
        }

        private void gvLnv_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
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