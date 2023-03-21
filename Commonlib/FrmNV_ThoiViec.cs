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
    public partial class FrmNV_ThoiViec : DevExpress.XtraEditors.XtraForm
    {
        public FrmNV_ThoiViec()
        {
            InitializeComponent();
        }
     
        cNhanVien_ThoiViec c_nvtv;
        cNhanVien _nhanvien;
        NhanVien c_NhanVien;
        int _id;
    
        static string strFormState;
        private void FrmNV_ThoiViec_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_NSDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qL_NSDataSet.NhanVien);

            c_nvtv = new cNhanVien_ThoiViec();
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
            gcTTNV.DataSource = c_nvtv.getListfULL();
            gvTTNV.OptionsBehavior.Editable = false;
        }
        void LoadNV()
        {
            txtMaNV.Properties.DataSource = _nhanvien.getListfull();
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
                c_nvtv.Delete(_id, 1);
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
        int SO;
        void so()
        {
            string query = "select count(*) from tb_TinhTrangNV";
            ConnectSql.GetDataToTable1(query, "tb_TinhTrangNV");
            SO = int.Parse(ConnectSql.ds.Tables["tb_TinhTrangNV"].Rows[0][0].ToString()) + 1;
            /* MessageBox.Show(IDNV.ToString());*/

        }
        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (strFormState == "ADDING")
            {
                so();
                tb_TinhTrangNV t_ttnvt = new tb_TinhTrangNV();
                t_ttnvt.SOQD = "QD/" + DateTime.Now.Year.ToString() + SO.ToString("D3") + "/QDTV" ;
                t_ttnvt.NgayNghi = dtpNN.Value;
                t_ttnvt.MaNV = txtMaNV.EditValue.ToString();
                t_ttnvt.NgayNopDon = dtpNND.Value;
                t_ttnvt.LyDo = txtLD.Text;
                t_ttnvt.GhiChu = txtGhiChu.Text;
                c_nvtv.Add(t_ttnvt);
                LoadData();
                btnDung.PerformClick();
                ConnectSql.XoaNoiDung(groupControl1);
                try
                {
                    c_NhanVien = new NhanVien();
                    var nv = _nhanvien.getitem(t_ttnvt.MaNV);
                    nv.DangLamViec = 0;
                    _nhanvien.Update(nv);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }

            }
            if (strFormState == "EDITTING")
            {
                var ttnv = c_nvtv.getItem(_id);
                ttnv.SOQD = txtSoQD.Text;
                ttnv.NgayNghi = dtpNN.Value;
                ttnv.NgayNopDon = dtpNND.Value;
                ttnv.LyDo = txtLD.Text;
                ttnv.MaNV = txtMaNV.EditValue.ToString();
                ttnv.GhiChu = txtGhiChu.Text;
                c_nvtv.Update(ttnv);
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

        private void gvTTNV_Click(object sender, EventArgs e)
        {
            try
            {
                _id = int.Parse(gvTTNV.GetFocusedRowCellValue("ID").ToString());
              
            }
            catch (Exception)
            {

                return;
            }

            var ttnv = c_nvtv.getItem(_id);
            // MessageBox.Show(pc.ToString());
            txtSoQD.Text = ttnv.SOQD;
            dtpNN.Value = DateTime.Parse(ttnv.NgayNghi.ToString());
            dtpNND.Value = DateTime.Parse(ttnv.NgayNopDon.ToString());
            txtLD.Text = ttnv.LyDo;
            txtMaNV.Text = ttnv.MaNV;
            txtGhiChu.Text = ttnv.GhiChu;
            splitContainer1.Panel1Collapsed = false;
            btnAnTT.Enabled = true;
        }

        private void gvTTNV_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "TrangThai" && e.CellValue != null)
            {
                Image img = Properties.Resources.cancel_16x16;
                e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
                e.Handled = true;
            }
        }
    }
}