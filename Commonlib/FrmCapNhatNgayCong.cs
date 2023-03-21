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
    public partial class FrmCapNhatNgayCong : DevExpress.XtraEditors.XtraForm
    {
        public FrmCapNhatNgayCong()
        {
            InitializeComponent();
        }
        public string _manv;
        public string _htnv;
        public int _makycong;
        public string _ngay;
        public int _cngay;
        KYCONGCT _kcct;
        BANGCONG_NV_CT _bcct_nv;
        FrmBangChamCong frm =(FrmBangChamCong)Application.OpenForms["FrmBangChamCong"];
        private void FrmCapNhatNgayCong_Load(object sender, EventArgs e)
        {
            _kcct = new KYCONGCT();
            _bcct_nv = new BANGCONG_NV_CT();
            lblHT.Text = _htnv;
            lblID.Text = _manv;
            string nam = _makycong.ToString().Substring(0,4);
            string thang = _makycong.ToString().Substring(4);
            string ngay = _ngay.Substring(1);
            DateTime _d =  DateTime.Parse(nam + "-" +  thang + "-" + ngay);
            mcldNCC.SetDate(_d);
         
            
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            //  MessageBox.Show(_manv + _htnv + _makycong.ToString() + _ngay);
            string _valueChamCong = rdgChamCong.Properties.Items[rdgChamCong.SelectedIndex].Value.ToString() + "-" + rdgThoiGian.Properties.Items[rdgThoiGian.SelectedIndex].Value.ToString();
            string _valueThoiGian = rdgThoiGian.Properties.Items[rdgThoiGian.SelectedIndex].Value.ToString();  
            // MessageBox.Show(_valueChamCong + _valueThoiGian);
            string feldname = "D" + _cngay.ToString();
            var kcct = _kcct.getid(_makycong, _manv);
           
            string query = "Update KYCONGCHITIET SET  " + feldname + "='" + _valueChamCong + "'WHERE Makycong = '" + _makycong + "'And MaNV = '" + _manv + "'";
            ConnectSql.RunSQL(query);

            if (mcldNCC.SelectionRange.Start.Year*100+mcldNCC.SelectionRange.Start.Month!=_makycong)
            {
                MessageBox.Show("Bạn chấm sai kỳ công. Vui lòng kiểm tra", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            BANGCONG_NHANVIEN_CHITIET bcctnv = _bcct_nv.GetItem(_makycong, _manv,mcldNCC.SelectionStart.Day);
            bcctnv.KYHIEU = _valueChamCong;
            if (mcldNCC.SelectionStart.DayOfWeek == DayOfWeek.Sunday)
            {
                if (_valueChamCong == "CT-NN")
                {
                    bcctnv.CONGCHUNHAT = 1;
                    bcctnv.NgayCong = 0;
                }
                else
                {
                    bcctnv.CONGCHUNHAT = 0.5;
                    bcctnv.NgayCong = 0;
                }
            }
            else
            {
                switch (_valueChamCong)
                {
                    
                    case "P-S":
                        bcctnv.NGAYPHEP = 0.5;
                        bcctnv.NgayCong = 0.5;
                        break;
                    case "P-C":
                        bcctnv.NGAYPHEP = 0.5;
                        bcctnv.NgayCong = 0.5;
                        break;
                    case "P-NN":
                        bcctnv.NGAYPHEP = 1;
                        bcctnv.NgayCong = 0;
                        break;
                    case "V-S":
                        bcctnv.NGAYPHEP = 0;
                        bcctnv.NgayCong = 0.5;
                        break;
                    case "V-C":
                        bcctnv.NGAYPHEP = 0;
                        bcctnv.NgayCong = 0.5;
                        break;
                    case "V-NN":
                        bcctnv.NGAYPHEP = 0;
                        bcctnv.NgayCong = 0;
                        break;
                    default:
                        break;
                }
            }
          

            _bcct_nv.Update(bcctnv);
            double tongngayCN = _bcct_nv.fc_TongNgayCN(_makycong, _manv);
            double tongngayphep = _bcct_nv.fc_TongNgayPhep(_makycong, _manv);
            double tongngaycong = _bcct_nv.fc_TongNgayCong(_makycong, _manv);
            /*     double tongngayle = _bcct_nv.fc_TongNgayLe(_makycong, _manv);
                 double tongngayCN = _bcct_nv.fc_TongNgayCN(_makycong, _manv);*/
            kcct.TONGNGAYCONG = tongngaycong;
            kcct.NGAYPHEP = tongngayphep;
            kcct.CONGCHUNHAT = tongngayCN;
            kcct.NGHIKHONGPHEP = kcct.NGAYCONG - kcct.TONGNGAYCONG - kcct.NGAYPHEP;
            _kcct.Update(kcct);


            if (ConnectSql.RunSql == true)
            {
                frm.loadBangCong();

            }
            


        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mcldNCC_DateSelected(object sender, DateRangeEventArgs e)
        {
            _cngay = mcldNCC.SelectionRange.Start.Day;
        }

        private void rdgChamCong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}