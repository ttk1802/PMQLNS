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
using DevExpress.XtraReports.UI;
using Data;
namespace Commonlib
{
    public partial class FrmBangLuong : DevExpress.XtraEditors.XtraForm
    {
        public FrmBangLuong()
        {
            InitializeComponent();
        }
        cBangLuong _cbangluong;
        List<tb_BangLuong> _lstbangluong;
        int _makycong;
        private void FrmBangLuong_Load(object sender, EventArgs e)
        {
            _cbangluong = new cBangLuong();
           
            cbNam.Text = DateTime.Now.Year.ToString();
            cbThang.Text = DateTime.Now.Month.ToString();
        }

      

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            if (_cbangluong.KiemTraPhatBangLuong(int.Parse(cbNam.Text) * 100 + int.Parse(cbThang.Text)))
            {
                MessageBox.Show("Bảng lương đã được phát sinh", "Thông báo");
                return;

            }
            else
            {
                _cbangluong.TinhLuongNV(int.Parse(cbNam.Text) * 100 + int.Parse(cbThang.Text));
                LoadData();
            }
           
        }
        void LoadData()
        {
          
           
                gcCV.DataSource = _cbangluong.getList(int.Parse(cbNam.Text) * 100 + int.Parse(cbThang.Text));
                gvCV.OptionsBehavior.Editable = false;
                _lstbangluong = _cbangluong.getList(int.Parse(cbNam.Text) * 100 + int.Parse(cbThang.Text));
                _makycong = int.Parse(cbNam.Text) * 100 + int.Parse(cbThang.Text);
          
          
        }
     

        private void btnXemBangLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
            if (gcCV.Container == null)
            {
                MessageBox.Show("Chưa có kỳ công");
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RptBangLuong rpt = new RptBangLuong(_lstbangluong, _makycong);
            rpt.ShowPreviewDialog();
        }
    }
}