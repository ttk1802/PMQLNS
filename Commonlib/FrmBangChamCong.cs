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
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraSplashScreen;
using Data;
using DevExpress.XtraReports.UI;

namespace Commonlib
{
    public partial class FrmBangChamCong : DevExpress.XtraEditors.XtraForm
    {
        public FrmBangChamCong()
        {
            InitializeComponent();
        }
        cNhanVien _nhanvien;
        KCONG _kc;
        KYCONGCT _kcct;
        BANGCONG_NV_CT _bangcongCT;
        public int _makycong;
        public int _thang;
        public int _nam;
     

        private void FrmBangCong_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClassApp.ChamCong = null;
        }
        public void loadBangCong()
        {
            _kcct = new KYCONGCT();
            gridControl1.DataSource = _kcct.getList(int.Parse(cbNam.Text) * 100 + int.Parse(cbThang.Text));
            CustomView(int.Parse(cbThang.Text), int.Parse(cbNam.Text));
            bandedGridView1.OptionsBehavior.Editable = false;
               
        }

        
        private void btnPS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(FrmWait), true, true);
            if (_kc.KiemTraPhatSinhKyCong(_makycong))
            {
                MessageBox.Show("Kỳ công đã được phát sinh", "Thông báo");
                SplashScreenManager.CloseForm();
                return;
            }

            List<NhanVien> lstNhanVien = _nhanvien.getList();
            _kcct.phatSinhKyCongChiTiet(int.Parse(cbThang.Text), int.Parse(cbNam.Text));
            foreach (var item in lstNhanVien)
            {
                for (int i = 1; i <= GetDayNumber(int.Parse(cbThang.Text), int.Parse(cbNam.Text)); i++)
                {
                    BANGCONG_NHANVIEN_CHITIET bcct = new BANGCONG_NHANVIEN_CHITIET();
                    bcct.MANV = item.MaNV;
                    bcct.HOTEN = item.TenNV;
                    bcct.GIOVAO = "08:00";
                    bcct.GIORA = "17:00";
                    bcct.NGAY = DateTime.Parse(cbNam.Text + "-" + cbThang.Text + "-" + i.ToString());
                    bcct.THU = ClassApp.layThuTrongTuan(int.Parse(cbNam.Text), int.Parse(cbThang.Text), i);
                    bcct.NGAYPHEP = 0;
                    bcct.CONGNGAYLE = 0;
                    bcct.CONGCHUNHAT = 0;
                    bcct.NGAYPHEP = 0;
                    if (bcct.THU == "Chủ nhật")
                    {
                        bcct.KYHIEU = "CN";
                        bcct.NgayCong = 0;
                    }

                    else
                    {
                        bcct.NgayCong = 1;
                        bcct.KYHIEU = "X";
                    }
                        
                    bcct.MAKYCONG = _makycong;
                    _bangcongCT.Add(bcct);
                }
            }
            
            _kcct.phatSinhKyCongChiTiet(int.Parse(cbThang.Text), int.Parse(cbNam.Text));
            var kc = _kc.getItem(_makycong);
            kc.TRANGTHAI = true;
            _kc.Update(kc);
            SplashScreenManager.CloseForm();
            loadBangCong();
        }
        private void CustomView(int thang, int nam)
        {
            bandedGridView1.RestoreLayoutFromXml(Application.StartupPath + @"\BangCong_Layout.xml");
            int i;
            foreach (GridColumn gridColumn in bandedGridView1.Columns)
            {
                if (gridColumn.FieldName == "HOTEN") continue;

                RepositoryItemTextEdit textEdit = new RepositoryItemTextEdit();
                textEdit.Mask.MaskType = MaskType.RegEx;
                textEdit.Mask.EditMask = @"\p{Lu}+";
                gridColumn.ColumnEdit = textEdit;
            }

            for (i = 1; i <= GetDayNumber(thang, nam); i++)
            {
                DateTime newDate = new DateTime(nam, thang, i);

                GridColumn column = new GridColumn();
                column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
                string fieldName = "D" + i;
                switch (newDate.DayOfWeek.ToString())
                {
                    case "Monday":
                        column = bandedGridView1.Columns[fieldName];
                        column.Caption = "T.Hai " + Environment.NewLine + i;
                        column.OptionsColumn.AllowEdit = true;
                        column.AppearanceHeader.ForeColor = Color.Blue;
                        column.AppearanceHeader.BackColor = Color.Transparent;
                        column.AppearanceHeader.BackColor2 = Color.Transparent;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Transparent;
                        column.OptionsColumn.AllowFocus = true;
                        //column.Width = 30;
                        //column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
                        break;

                    case "Tuesday":
                        column = bandedGridView1.Columns[fieldName];
                        column.Caption = "T.Ba " + Environment.NewLine + i;
                        column.OptionsColumn.AllowEdit = true;
                        column.AppearanceHeader.ForeColor = Color.Blue;
                        column.AppearanceHeader.BackColor = Color.Transparent;
                        column.AppearanceHeader.BackColor2 = Color.Transparent;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Transparent;
                        column.OptionsColumn.AllowFocus = true;
                        //column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
                        //column.Width = 30;
                        break;

                    case "Wednesday":
                        column = bandedGridView1.Columns[fieldName];
                        column.Caption = "T.Tư " + Environment.NewLine + i;
                        column.OptionsColumn.AllowEdit = true;
                        column.AppearanceHeader.ForeColor = Color.Blue;
                        column.AppearanceHeader.BackColor = Color.Transparent;
                        column.AppearanceHeader.BackColor2 = Color.Transparent;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Transparent;
                        column.OptionsColumn.AllowFocus = true;
                        //column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
                        //column.Width = 30;
                        break;
                    case "Thursday":
                        column = bandedGridView1.Columns[fieldName];
                        column.Caption = "T.Năm " + Environment.NewLine + i;
                        column.OptionsColumn.AllowEdit = true;
                        column.AppearanceHeader.ForeColor = Color.Blue;
                        column.AppearanceHeader.BackColor = Color.Transparent;
                        column.AppearanceHeader.BackColor2 = Color.Transparent;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Transparent;
                        column.OptionsColumn.AllowFocus = true;
                        //column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
                        //column.Width = 30;
                        break;
                    case "Friday":
                        column = bandedGridView1.Columns[fieldName];
                        column.Caption = "T.Sáu " + Environment.NewLine + i;
                        column.OptionsColumn.AllowEdit = true;
                        column.AppearanceHeader.ForeColor = Color.Blue;
                        column.AppearanceHeader.BackColor = Color.Transparent;
                        column.AppearanceHeader.BackColor2 = Color.Transparent;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Transparent;
                        column.OptionsColumn.AllowFocus = true;
                        //column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
                        //column.Width = 30;
                        break;
                    case "Saturday":
                        column = bandedGridView1.Columns[fieldName];
                        column.Caption = "T.Bảy " + Environment.NewLine + i;
                        column.OptionsColumn.AllowEdit = true;
                        column.AppearanceHeader.ForeColor = Color.White;
                        column.AppearanceHeader.BackColor = Color.Blue;
                        column.AppearanceHeader.BackColor2 = Color.Blue;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Khaki;
                        column.OptionsColumn.AllowFocus = true;
                        //column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
                        //column.Width = 30;
                        break;
                    case "Sunday":
                        column = bandedGridView1.Columns[fieldName];
                        column.Caption = "CN " + Environment.NewLine + i;
                        column.OptionsColumn.AllowEdit = false;
                        column.AppearanceHeader.ForeColor = Color.White;
                        column.AppearanceHeader.BackColor = Color.Red;
                        column.AppearanceHeader.BackColor2 = Color.Red;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Orange;
                        //column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
                        //column.Width = 30;
                        //column.OptionsColumn.AllowFocus = false;
                        break;
                }
            }

            while (i <= 31)
            {
                bandedGridView1.Columns[i + 1].Visible = false;
                i++;
            }

        }
        private int GetDayNumber(int thang, int nam)
        {
            int dayNumber = 0;
            switch (thang)
            {
                case 2:
                    dayNumber = (nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0 ? 29 : 28;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    dayNumber = 30;
                    break;

                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    dayNumber = 31;
                    break;
            }

            return dayNumber;
        }

        private void btnXem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            loadBangCong();
           
        }

        private void mnuCNNC_Click(object sender, EventArgs e)
        {
            FrmCapNhatNgayCong frm = new FrmCapNhatNgayCong();
          
            frm._htnv = bandedGridView1.GetFocusedRowCellValue("HOTEN").ToString();
            frm._manv = bandedGridView1.GetFocusedRowCellValue("MANV").ToString();
            frm._ngay = bandedGridView1.FocusedColumn.FieldName.ToString();
            frm._makycong = _makycong;
            frm.ShowDialog();


        }

        private void FrmBangChamCong_Load(object sender, EventArgs e)
        {
            _nhanvien = new cNhanVien();
            _bangcongCT = new BANGCONG_NV_CT();
            _kc = new KCONG();
            _kcct = new KYCONGCT();
            gridControl1.DataSource = _kcct.getList(_makycong);
            CustomView(_thang, _nam);
            cbThang.Text = _thang.ToString();
            cbNam.Text = _nam.ToString();
            bandedGridView1.OptionsBehavior.Editable = false;
        }

        private void bandedGridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.CellValue!=null)
            {
                if (e.CellValue.ToString() == "P-S")
                {
                    e.Appearance.BackColor = Color.LightBlue;
                }
                if (e.CellValue.ToString() == "P-C")
                {
                    e.Appearance.BackColor = Color.LightBlue;
                }
                if (e.CellValue.ToString() == "P-NN")
                {
                    e.Appearance.BackColor = Color.LightBlue;
                }
                if (e.CellValue.ToString() == "V-C")
                {
                    e.Appearance.BackColor = Color.IndianRed;
                    e.Appearance.ForeColor = Color.White;
                }
                if (e.CellValue.ToString() == "V-S")
                {
                    e.Appearance.BackColor = Color.IndianRed;
                    e.Appearance.ForeColor = Color.White;
                }
                if (e.CellValue.ToString() == "V-NN")
                {
                    e.Appearance.BackColor = Color.IndianRed;
                    e.Appearance.ForeColor = Color.White;
                }
            }
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<KYCONGCHITIET> lst = _kcct.getList(_makycong);
            PrtBangCongTongHop rp = new PrtBangCongTongHop(lst, _makycong.ToString());
        
            rp.ShowPreviewDialog();
        }

       
    }
}