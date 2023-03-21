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
    public partial class FrmHopDong : DevExpress.XtraEditors.XtraForm
    {
        public FrmHopDong()
        {
            InitializeComponent();
        }
        cHopDongLD _chopdongld;
        cNhanVien _cnhanvien;
        int _id;
        static string strFormState;
        private void FrmHopDong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_NSDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qL_NSDataSet.NhanVien);
            _chopdongld = new cHopDongLD();
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
            gcHD.DataSource = _chopdongld.getlistfull();
            gvHD.OptionsBehavior.Editable = false;
        }
        void LoadNV()
        {
            sluNV.Properties.DataSource = _cnhanvien.getListfull();
            sluNV.Properties.DisplayMember = "TenNV";
            sluNV.Properties.ValueMember = "MaNV";
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
                _chopdongld.Delete(_id);
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
        int SOHD;
        void MaxSOHD()
        {
            string query = "select count(tb_HopDong.MaHD) from tb_HopDong";
            ConnectSql.GetDataToTable1(query, "tb_HopDong");
            SOHD = int.Parse(ConnectSql.ds.Tables["tb_HopDong"].Rows[0][0].ToString()) + 1;
            // MessageBox.Show(SOHD.ToString());

        }
        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (strFormState == "ADDING")
            {
                MaxSOHD();
                tb_HopDong hd = new tb_HopDong();
                hd.SOHD = "HD" + SOHD.ToString("D3") + "/" + dtpNK.Value.ToShortDateString();
                hd.NgayKy = dtpNK.Value;
                hd.Tungay = dtpNBD.Value;
                hd.Denngay = dtpNKT.Value;
                hd.LoaiHD = cbLHD.Text;
                hd.NoiDung = richEditControl1.RtfText;
                hd.ThoiHan = txtThoiHan.Text;
                hd.MaNV = sluNV.EditValue.ToString();
                _chopdongld.Add(hd);
                LoadData();
                btnDung.PerformClick();
            }
            if (strFormState == "EDITTING")
            {
                var hd = _chopdongld.getitem(_id);
                hd.NgayKy = dtpNK.Value;
                hd.Tungay = dtpNBD.Value;
                hd.Denngay = dtpNKT.Value;
                hd.LoaiHD = cbLHD.SelectedValue.ToString();
                hd.ThoiHan = txtThoiHan.Text;
                hd.NoiDung = richEditControl1.RtfText;
                hd.MaNV = sluNV.EditValue.ToString();
                _chopdongld.Update(hd);
                LoadData();
                btnDung.PerformClick();
            }
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

        private void gvHD_Click(object sender, EventArgs e)
        {
            try
            {
                _id = int.Parse(gvHD.GetFocusedRowCellValue("MaHD").ToString());
            }
            catch (Exception)
            {

                return;
            }
           
            var hd = _chopdongld.getitem(_id);
            dtpNK.Value = DateTime.Parse(hd.NgayKy.ToString());
            dtpNBD.Value = DateTime.Parse(hd.Tungay.ToString());
            dtpNKT.Value = DateTime.Parse(hd.Denngay.ToString());
            cbLHD.SelectedValue = hd.LoaiHD;
          //  txtNoiDung.Text = hd.NoiDung ;
            richEditControl1.RtfText= hd.NoiDung ;
            txtThoiHan.Text = hd.ThoiHan;
            sluNV.Text = hd.MaNV;
            splitContainer1.Panel1Collapsed = false;
            btnAnTT.Enabled = true;
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

        private void richEditControl1_Click(object sender, EventArgs e)
        {

        }
    }
}