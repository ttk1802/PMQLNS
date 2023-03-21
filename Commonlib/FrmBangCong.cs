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
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DevExpress.XtraSplashScreen;

namespace Commonlib
{
    public partial class FrmBangCong : DevExpress.XtraEditors.XtraForm
    {
        public FrmBangCong()
        {
            InitializeComponent();
        }
        static string strFormState;
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        
            btnThoat.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnIn.Enabled = false;
            btnXoa.Enabled = false;
            strFormState = "ADDING";

            btnLuu.Enabled = true;
            btnDung.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult warn = MessageBox.Show("Are you sure ?", "Warning!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (warn == DialogResult.Yes)
            {
                DataRow row = ConnectSql.ds.Tables["KYCONG"].Rows[ClassApp.vt];
                row.Delete();
                int rs = ConnectSql.adapter.Update(ConnectSql.ds.Tables["KYCONG"]);
                if (rs > 0)
                {
                    MessageBox.Show("Xóa dữ liệu thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa dữ liệu thất bại!");
                }
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThoat.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnIn.Enabled = false;
            btnXoa.Enabled = false;
            strFormState = "EDITTING";

            btnLuu.Enabled = true;
            btnDung.Enabled = true;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (strFormState == "ADDING")
            {
                DataRow row = ConnectSql.ds.Tables["KYCONG"].NewRow();
                row["MAKYCONG"] = int.Parse(cbNam.Text) * 100 + int.Parse(cbThang.Text);
                row["THANG"] = int.Parse(cbThang.Text);
                row["NAM"] = int.Parse(cbNam.Text);
                row["KHOA"] = ckbKhoa.Checked;
                row["NGAYTINHCONG"] = DateTime.Now;
                row["NGAYCONGTRONGTHANG"] = ClassApp.demSoNgayLamViecTrongThang(int.Parse(cbThang.Text),int.Parse(cbNam.Text) );
                row["TRANGTHAI"] = ckbTT.Checked;
                try
                {
                    ConnectSql.ds.Tables["KYCONG"].Rows.Add(row);
                    int rs = ConnectSql.adapter.Update(ConnectSql.ds.Tables["KYCONG"]);
                    if (rs > 0)
                    {
                        MessageBox.Show("Thêm dữ liệu thành công!");
                        btnDung.PerformClick();
                    }

                    else
                    {
                        MessageBox.Show("Thêm dữ liệu thất bại!");
                    }
                    ShowAllBangCong();
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi");
                    ShowAllBangCong();

                }
            }
            else if (strFormState == "EDITTING")
            {
                DataRow row = ConnectSql.ds.Tables["KYCONG"].Rows[ClassApp.vt];
                row.BeginEdit();
                row["MAKYCONG"] = int.Parse(cbNam.Text) * 100 + int.Parse(cbThang.Text);
                row["THANG"] = int.Parse(cbThang.Text);
                row["NAM"] = int.Parse(cbNam.Text);
                row["KHOA"] = ckbKhoa.Checked;
                row["NGAYTINHCONG"] = DateTime.Now;
                row["NGAYCONGTRONGTHANG"] = ClassApp.demSoNgayLamViecTrongThang(int.Parse(cbThang.Text), int.Parse(cbNam.Text));
                row["TRANGTHAI"] = ckbTT.Checked;
                row.EndEdit();
                try
                {

                    int rs = ConnectSql.adapter.Update(ConnectSql.ds.Tables["KYCONG"]);
                    if (rs > 0)
                    {
                        MessageBox.Show("Chỉnh sửa liệu thành công!!");
                        btnDung.PerformClick();
                    }

                    else
                    {
                        MessageBox.Show("Chỉnh sửa dữ liệu thất bại!i!");
                    }
                    ShowAllBangCong();
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi");
                    ShowAllBangCong();

                }
            }
        }

        private void btnDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnLuu.Enabled = false;
            btnThoat.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnIn.Enabled = true;
            btnXoa.Enabled = true;
            btnDung.Enabled = false;
            btnAnTT.Enabled = true;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
        private void ShowAllBangCong()
        { 
            string query = "SELECT * FROM KYCONG";
            ConnectSql.GetDataToTable1(query, "KYCONG");
            dgvBC.DataSource = ConnectSql.ds.Tables["KYCONG"];
            ChangColumn();
        }
        private void ChangColumn()
        {
            dgvBC.Columns[0].HeaderText = "Mã kỳ công";
            dgvBC.Columns[1].HeaderText = "Tháng";
            dgvBC.Columns[2].HeaderText = "Năm";
            dgvBC.Columns[3].HeaderText = "Khóa";
            dgvBC.Columns[4].HeaderText = "Ngày tính công";
            dgvBC.Columns[5].HeaderText = "Số ngày công";
            dgvBC.Columns[6].HeaderText = "Trạng thái";
        }
        private void FrmBangCong_Load(object sender, EventArgs e)
        {
            ClassApp.vt = 0;
            cbNam.Text = DateTime.Now.Year.ToString();
            cbThang.Text = DateTime.Now.Month.ToString();
            btnLuu.Enabled = false;
            btnDung.Enabled = false;
            ShowAllBangCong();
            strFormState = "NORMAL";
            
        }

        private void dgvBC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ClassApp.vt = e.RowIndex;
                if (ClassApp.vt == -1 || ClassApp.vt == ConnectSql.ds.Tables["KYCONG"].Rows.Count) return;
                DataRow row = ConnectSql.ds.Tables["KYCONG"].Rows[ClassApp.vt];
                 cbThang.Text = row["THANG"].ToString();
                 cbNam.Text = row["NAM"].ToString();
                 ckbKhoa.Checked = bool.Parse(row["KHOA"].ToString());
                 ckbTT.Checked = bool.Parse(row["TRANGTHAI"].ToString());
            }
            catch (Exception)
            {
                return;
            }

        }

        private void FrmBangCong_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClassApp.BangCong = null;
        }

        private void btnChamCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmBangChamCong frm = new FrmBangChamCong();
            if (ClassApp.vt < 1)
            {
                ClassApp.vt = 0;
                frm._nam = int.Parse(ConnectSql.ds.Tables["KYCONG"].Rows[ClassApp.vt][0].ToString().Substring(0, 4));
                frm._thang = int.Parse(ConnectSql.ds.Tables["KYCONG"].Rows[ClassApp.vt][0].ToString().Substring(4));;
              
            }
            else {
                frm._thang = int.Parse(cbThang.Text);
                frm._nam = int.Parse(cbNam.Text);
            }
            frm._makycong = int.Parse(ConnectSql.ds.Tables["KYCONG"].Rows[ClassApp.vt][0].ToString());
            frm.ShowDialog();
        }
    }
}