using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Data;
using Commonlib.join;
using System.Collections.Generic;

namespace Commonlib
{
    public partial class RptBangLuong : DevExpress.XtraReports.UI.XtraReport
    {
        public RptBangLuong()
        {
            InitializeComponent();
        }
        List<tb_BangLuong> _lst;
        int _makycong;
        public RptBangLuong(List<tb_BangLuong> _lbangluong, int makc )
        {
            InitializeComponent();
            this._lst = _lbangluong;
            this._makycong = makc;
            this.DataSource = _lst; LoadData();
            lblThangNam.Text = "Tháng " + _makycong.ToString().Substring(4) + " năm " + _makycong.ToString().Substring(0,4);
        } 
        void LoadData()
        {
            lblManv.DataBindings.Add("Text", DataSource, "MaNV");
            lblHoten.DataBindings.Add("Text", DataSource, "TenNV");
            lblCong.DataBindings.Add("Text", DataSource, "NgayCongTrongThang");
            lblNgayThuong.DataBindings.Add("Text", DataSource, "NgayThuong");
            lbllPhep.DataBindings.Add("Text", DataSource, "NgayPhep");
            lblLLe.DataBindings.Add("Text", DataSource, "NgayLe");
            lblLCN.DataBindings.Add("Text", DataSource, "NgayChuNhat");
            lblPhuCap.DataBindings.Add("Text", DataSource, "PhuCap");
            lblTangca.DataBindings.Add("Text", DataSource, "TangCa");
            lblUngLuong.DataBindings.Add("Text", DataSource, "UngLuong");
            lblBHYT.DataBindings.Add("Text", DataSource, "BHYT");
            lblBHXH.DataBindings.Add("Text", DataSource, "BHXH");
            lblBHTN.DataBindings.Add("Text", DataSource, "BHTN");
            lblThucLanh.DataBindings.Add("Text", DataSource, "ThucLanh");
           
           
        }

    }
}
