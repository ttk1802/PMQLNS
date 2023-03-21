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
    public partial class FrmPhanCong : DevExpress.XtraEditors.XtraForm
    {
        public FrmPhanCong()
        {
            InitializeComponent();
        }
        cPhanCong _cphancong;
        cChucVu c_chucvu;
        cPhongBan c_phongban;
        cNhanVien _nhanvien;
        NhanVien c_NhanVien;
        int _id;
        static string strFormState;
        private void FrmPhanCong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_NSDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qL_NSDataSet.NhanVien);
            _cphancong = new cPhanCong();
            c_chucvu = new cChucVu();
            _nhanvien = new cNhanVien();
            c_phongban = new cPhongBan();
            c_NhanVien = new NhanVien();
            LoadData();
            LoadComBo();
            LoadNV();
            txtMaNV.Text = FrmNhanVien.idnv;
            btnLuu.Enabled = false;
            btnDung.Enabled = false;
            //splitContainer1.Panel1Collapsed = true;
            btnAnTT.Enabled = false;
        }
        void LoadData()
        {
            gcPC.DataSource = _cphancong.getlistfull();
            gvPC.OptionsBehavior.Editable = false;
        }
        void LoadComBo()
        {
            cbPB.DataSource = c_phongban.getlist();
            cbPB.DisplayMember = "TenPB";
            cbPB.ValueMember = "MaPB";

            cbCV.DataSource = c_chucvu.getlist();
            cbCV.DisplayMember = "TenCV";
            cbCV.ValueMember = "MaCV";


        }
        void LoadNV()
        {
            txtMaNV.Properties.DataSource = _nhanvien.getListfull();
            txtMaNV.Properties.DisplayMember = "TenNV";
            txtMaNV.Properties.ValueMember = "MaNV";
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*ConnectSql.XoaNoiDung(groupControl1);*/
            splitContainer1.Panel1Collapsed = false;
            btnThoat.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            strFormState = "ADDING";

            btnLuu.Enabled = true;
            btnDung.Enabled = true;
            btnAnTT.Enabled = false;

            cbPB.Focus();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult warn = MessageBox.Show("Are you sure ?", "Warning!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (warn == DialogResult.Yes)
            {
                _cphancong.Delete(_id);
                LoadData();
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cbPB.Focus();
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
               
                tb_PhanCong pc = new tb_PhanCong();
                _cphancong.UpdateItem(pc, txtMaNV.EditValue.ToString());
                pc.MaPB = int.Parse(cbPB.SelectedValue.ToString());
                pc.MaCV = int.Parse(cbCV.SelectedValue.ToString());
                pc.TenPC = cbCV.Text + " - " + cbPB.Text;
                pc.MaNV = txtMaNV.EditValue.ToString();
                pc.TrangThai = true;
                pc.ThoiGian = dtpTG.Value;
                _cphancong.Add(pc);
                LoadData();
                btnDung.PerformClick();
                ConnectSql.XoaNoiDung(groupControl1);
            }
            if (strFormState == "EDITTING")
            {
                tb_PhanCong pc_old = new tb_PhanCong();
                _cphancong.UpdateItem(pc_old, txtMaNV.EditValue.ToString());
                var pc = _cphancong.getitem(_id);
                
                pc.MaPB = int.Parse(cbPB.SelectedValue.ToString());
                pc.MaCV = int.Parse(cbCV.SelectedValue.ToString());
                pc.TenPC = cbCV.Text + " - " + cbPB.Text;
                pc.MaNV = txtMaNV.EditValue.ToString();
                pc.TrangThai = ckbTT.Checked;
                pc.ThoiGian = dtpTG.Value;
                _cphancong.Update(pc);
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

        private void btnAnTT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splitContainer1.Panel1Collapsed = true;
            btnAnTT.Enabled = false;
        }
       /* public static string fMaNV;
        public static string fTenNV;
        private void btnTKNV_Click(object sender, EventArgs e)
        {
            FrmTimKiemNV frm = new FrmTimKiemNV();
            frm.ShowDialog();
            txtMaNV.Text = fMaNV;
            txtTenNV.Text = fTenNV;
        }
        */
        private void gvPC_Click(object sender, EventArgs e)
        {
            try
            {
                _id = int.Parse(gvPC.GetFocusedRowCellValue("MaPC").ToString());
            }
            catch (Exception)
            {

                return;
            }

            var pc = _cphancong.getitem(_id);
           // MessageBox.Show(pc.ToString());
            cbPB.SelectedValue = pc.MaPB;
            cbCV.SelectedValue = pc.MaCV;
            ckbTT.Checked = pc.TrangThai.Value;
            dtpTG.Value = pc.ThoiGian.Value;
            txtMaNV.Text = pc.MaNV;
            splitContainer1.Panel1Collapsed = false;
            btnAnTT.Enabled = true;
        }
    }
}