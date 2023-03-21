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
using System.IO;
using Data;
using Commonlib.join;
using DevExpress.XtraReports.UI;
namespace Commonlib
{
    public partial class FrmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }
        cNhanVien _cNhanVien;
        cTrinhDo _ctrinhdo;
        cPhanCong _cphancong;
        string _id;
        static string strFormState;
        List<cNhanVienjoin> lstNVJ;
        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            _cNhanVien = new cNhanVien();
            _ctrinhdo = new cTrinhDo();
            _cphancong = new cPhanCong();
            FrmPhanCong pc = new FrmPhanCong();
            
            LoadData();
            LoadComBo();
            btnLuu.Enabled = false;
            btnDung.Enabled = false;
            splitContainer1.Panel1Collapsed = true;
            btnAnTT.Enabled = false;
        }
        void LoadData()
        {
            gcNV.DataSource = _cNhanVien.getListfull_All();
            gvNV.OptionsBehavior.Editable = false;
            lstNVJ = _cNhanVien.getListfull();
        }
        void LoadComBo()
        {
           /* cbTPC.DataSource = _cphancong.getlist();
            cbTPC.DisplayMember = "TenPC";
            cbTPC.ValueMember = "MaPC";*/

            cbTTD.DataSource = _ctrinhdo.getlist();
            cbTTD.DisplayMember = "TenTD";
            cbTTD.ValueMember = "MaTD";
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

            txtTenNV.Focus();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult warn = MessageBox.Show("Are you sure ?", "Warning!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (warn == DialogResult.Yes)
            {
                _cNhanVien.Delete(_id, 0);
                LoadData();
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtTenNV.Focus();
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
        int IDNV;
        void MaxIDNV()
        {
            string query = "select count(NhanVien.MaNV) from NhanVien";
            ConnectSql.GetDataToTable1(query, "NhanVien");
            IDNV = int.Parse(ConnectSql.ds.Tables["NhanVien"].Rows[0][0].ToString()) + 1;
            /* MessageBox.Show(IDNV.ToString());*/

        }
        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (strFormState == "ADDING")
            {
                MaxIDNV();

                NhanVien nv = new NhanVien();
                nv.MaNV = "NV" + IDNV.ToString("D3");
                nv.TenNV = txtTenNV.Text;
                nv.GioiTinh = ckbGT.Checked;
                nv.NgaySinh = dateTimePicker1.Value;
                nv.SDT = txtSDT.Text;
                nv.DiaChi = txtDC.Text;
                nv.CCCD = txtCCCD.Text;
                nv.HinhAnh = ImageToBase(pictureBox1.Image, pictureBox1.Image.RawFormat);
                nv.MaTD = int.Parse(cbTTD.SelectedValue.ToString());
                _cNhanVien.Add(nv);
                LoadData();
                btnDung.PerformClick();
                ConnectSql.XoaNoiDung(groupControl1);
            }
            if (strFormState == "EDITTING")
            {
                var nv = _cNhanVien.getitem(_id);
                nv.TenNV = txtTenNV.Text;
                nv.GioiTinh = ckbGT.Checked;
                nv.NgaySinh = dateTimePicker1.Value;
                nv.SDT = txtSDT.Text;
                nv.DiaChi = txtDC.Text;
                nv.CCCD = txtCCCD.Text;
                nv.HinhAnh = ImageToBase(pictureBox1.Image, pictureBox1.Image.RawFormat);
                nv.MaTD = int.Parse(cbTTD.SelectedValue.ToString());
                _cNhanVien.Update(nv);
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
            RptDanhSachNhanVien rpt = new RptDanhSachNhanVien(lstNVJ);
            rpt.ShowPreview();
         }

        private void btnAnTT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splitContainer1.Panel1Collapsed = true;
            btnAnTT.Enabled = false;
        }
        public static string idnv;
        private void btnPhanCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            idnv = _id;
            FrmPhanCong pc = new FrmPhanCong();
       
            pc.ShowDialog();
            
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Picture file (.png, .jpg)| *.png; *.jpg";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openfile.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

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
            txtTenNV.Text = nv.TenNV;
            ckbGT.Checked = nv.GioiTinh.Value;
            dateTimePicker1.Value = nv.NgaySinh.Value;
            txtSDT.Text = nv.SDT;
            txtDC.Text = nv.DiaChi;
            txtCCCD.Text = nv.CCCD;
            pictureBox1.Image = BaseToImage(nv.HinhAnh);
            cbTTD.SelectedValue = nv.MaTD;

            splitContainer1.Panel1Collapsed = false;
            btnAnTT.Enabled = true;
        }
        public byte[] ImageToBase(Image img, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, format);
                byte[] imagebits = ms.ToArray();
                return imagebits;
            }
        }
        public Image BaseToImage(byte[] imagebits)
        {
            MemoryStream ms = new MemoryStream(imagebits, 0, imagebits.Length);
            ms.Write(imagebits, 0, imagebits.Length);
            Image image = Image.FromStream(ms, true);
            return image;

        }

        private void gvNV_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "DangLamViec" && e.CellValue != null)
            {
                Image img = Properties.Resources.cancel_16x16;
                e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
                e.Handled = true;
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            idnv = _id;
            FrmQTNL frm = new FrmQTNL();
            frm.ShowDialog();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            idnv = _id;
            FrmQTPC frm = new FrmQTPC();
            frm.ShowDialog();
        }
    }
}