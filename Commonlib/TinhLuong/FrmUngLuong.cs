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
    public partial class FrmUngLuong : DevExpress.XtraEditors.XtraForm
    {
        public FrmUngLuong()
        {
            InitializeComponent();
        }
        cUngLuong _cungluong;
        cNhanVien _cnhanvien;
        int _id;
        static string strFormState;
        private void FrmUngLuong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_NSDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qL_NSDataSet.NhanVien);
            _cungluong = new cUngLuong();
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
            gcUL.DataSource = _cungluong.getlistFull();
            gvUL.OptionsBehavior.Editable = false;

        }
        void LoadNV()
        {
            searchlookupeditNV.Properties.DataSource = _cnhanvien.getListfull();
            searchlookupeditNV.Properties.DisplayMember = "TenNV";
            searchlookupeditNV.Properties.ValueMember = "MaNV";
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
                _cungluong.Delete(_id, 1);
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

                tb_UngLuong pc = new tb_UngLuong();
                pc.SoTien = float.Parse(txtSoTien.Text);
                pc.MaNV = searchlookupeditNV.EditValue.ToString();
                pc.Ngay = int.Parse(txtNgay.Text);
                pc.Thang = int.Parse(txtThang.Text);
                pc.Nam = int.Parse(txtNam.Text);
                pc.GhiChu = txtGhiChu.Text;
                pc.TrangThai = 0;
                _cungluong.Add(pc);
                LoadData();
                btnDung.PerformClick();
            }
            if (strFormState == "EDITTING")
            {
                var ul = _cungluong.getItem(_id);
               
                ul.SoTien = float.Parse(txtSoTien.Text);
                ul.MaNV = searchlookupeditNV.EditValue.ToString();
                ul.Ngay = int.Parse(txtNgay.Text);
                ul.Thang = int.Parse(txtThang.Text);
                ul.Nam = int.Parse(txtNam.Text);
                ul.GhiChu = txtGhiChu.Text;
                _cungluong.Update(ul);
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

        private void gvUL_Click(object sender, EventArgs e)
        {
            try
            {
                _id = int.Parse(gvUL.GetFocusedRowCellValue("ID").ToString());
                var hd = _cungluong.getItem(_id);
                txtGhiChu.Text = hd.GhiChu;
                txtSoTien.Text = hd.SoTien.ToString();
                searchlookupeditNV.EditValue = hd.MaNV;
                txtNgay.Text = hd.Ngay.ToString();
                txtThang.Text = hd.Thang.ToString();
                txtNam.Text = hd.Nam.ToString();
                splitContainer1.Panel1Collapsed = false;
                btnAnTT.Enabled = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Dữ liệu rỗng");
            }
        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}