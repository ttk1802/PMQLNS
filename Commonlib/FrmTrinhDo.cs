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
    public partial class FrmTrinhDo : DevExpress.XtraEditors.XtraForm
    {
        public FrmTrinhDo()
        {
            InitializeComponent();
        }
        cTrinhDo _ctrinhdo;
        int _id;
        static string strFormState;
        private void FrmTrinhDo_Load(object sender, EventArgs e)
        {
            _ctrinhdo = new cTrinhDo();
            LoadData();
            btnLuu.Enabled = false;
            btnDung.Enabled = false;
            splitContainer1.Panel1Collapsed = true;
            btnAnTT.Enabled = false;
        }
        void LoadData()
        {
            gcTD.DataSource = _ctrinhdo.getlist();
            gvTD.OptionsBehavior.Editable = false;
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

            txtTenTD.Focus();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult warn = MessageBox.Show("Are you sure ?", "Warning!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (warn == DialogResult.Yes)
            {
                _ctrinhdo.Delete(_id);
                LoadData();
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtTenTD.Focus();
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
                /*  Cao đẳng => CD (ID)
                 * string SampleText = "Stack Overflow Com";
                string ShortName = "";
                SystemName.Split(' ').ToList().ForEach(i => ShortName += i[0].ToString());*/
                tb_TrinhDo td = new tb_TrinhDo();
                td.TenTD = txtTenTD.Text;
                _ctrinhdo.Add(td);
                LoadData();
                btnDung.PerformClick();
            }
            if (strFormState == "EDITTING")
            {
                var td = _ctrinhdo.getitem(_id);
                td.TenTD = txtTenTD.Text;
                _ctrinhdo.Update(td);
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

        private void gvTD_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvTD.GetFocusedRowCellValue("MaTD").ToString());
            txtTenTD.Text = gvTD.GetFocusedRowCellValue("TenTD").ToString();
            splitContainer1.Panel1Collapsed = false;
            btnAnTT.Enabled = true;
        }
    }
}