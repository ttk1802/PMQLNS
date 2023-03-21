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
    public partial class FrmPhuCap : DevExpress.XtraEditors.XtraForm
    {
        public FrmPhuCap()
        {
            InitializeComponent();
        }
        cPhuCap _cphucap;
        cNhanVien _cnhanvien;
        int _id;
        static string strFormState;
        private void FrmPhuCap_Load(object sender, EventArgs e)
        {
            _cphucap = new cPhuCap();
            _cnhanvien = new cNhanVien();
            LoadData();
            LoadNV();
            LoadPC();
            btnLuu.Enabled = false;
            btnDung.Enabled = false;
            splitContainer1.Panel1Collapsed = true;
            btnAnTT.Enabled = false;
            cbPC.SelectedIndexChanged += CbPC_SelectedIndexChanged;
        }

        private void CbPC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var pc = _cphucap.getitemPC(int.Parse(cbPC.SelectedValue.ToString()));
                if (pc != null)
                {
                    txtSoTien.Text = pc.SoTien.ToString();
                }
            }
            catch (Exception)
            {

                return;
            }
            
           
        }

        void LoadData()
        {
            gcPC.DataSource = _cphucap.getlistfull();
            gvPC.OptionsBehavior.Editable = false;

        }
        void LoadNV()
        {
            searchlookupeditNV.Properties.DataSource = _cnhanvien.getListfull();
            searchlookupeditNV.Properties.DisplayMember = "TenNV";
            searchlookupeditNV.Properties.ValueMember = "MaNV";
        }
        void LoadPC()
        {
            cbPC.DataSource = _cphucap.getlistPC();
            cbPC.DisplayMember = "TenPCap";
            cbPC.ValueMember = "MaPCap";
        }
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult warn = MessageBox.Show("Are you sure ?", "Warning!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (warn == DialogResult.Yes)
            {
                _cphucap.Delete(_id, 0);
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
              
                tb_PhuCap_NhanVien pc = new tb_PhuCap_NhanVien();
                pc.MaPCap = int.Parse(cbPC.SelectedValue.ToString());
                pc.SoTien = float.Parse(txtSoTien.Text);
                pc.MaNV = searchlookupeditNV.EditValue.ToString();
                pc.Ngay = dtpNgayNhan.Value;
                pc.NoiDung = txtGhiChu.Text;
                pc.Delete_by = 1;
                _cphucap.Add(pc);
                LoadData();
                btnDung.PerformClick();
            }
            if (strFormState == "EDITTING")
            {
                var pc = _cphucap.getitem(_id);
                pc.MaPCap = int.Parse(cbPC.SelectedValue.ToString());
                pc.SoTien = float.Parse(txtSoTien.Text);
                pc.MaNV = searchlookupeditNV.EditValue.ToString();
                pc.Ngay = dtpNgayNhan.Value;
                pc.NoiDung = txtGhiChu.Text;
                _cphucap.Update(pc);
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

        private void btnAnTT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splitContainer1.Panel1Collapsed = true;
            btnAnTT.Enabled = false;
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

            //txtTenpc.Focus();
        }

        private void gvPC_Click(object sender, EventArgs e)
        {
            try
            {
                _id = int.Parse(gvPC.GetFocusedRowCellValue("ID").ToString());
                txtGhiChu.Text = gvPC.GetFocusedRowCellValue("NoiDung").ToString();
                txtSoTien.Text = gvPC.GetFocusedRowCellValue("SoTien").ToString();
                searchlookupeditNV.EditValue = gvPC.GetFocusedRowCellValue("MaNV").ToString();
                cbPC.SelectedValue = gvPC.GetFocusedRowCellValue("MaPCap").ToString();
                splitContainer1.Panel1Collapsed = false;
                btnAnTT.Enabled = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Dữ liệu rỗng");
            }
     
           
        }
    }
}