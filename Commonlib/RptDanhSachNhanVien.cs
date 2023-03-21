using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Commonlib.join;

namespace Commonlib
{
    public partial class RptDanhSachNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public RptDanhSachNhanVien()
        {
            InitializeComponent();
        }
        List<cNhanVienjoin> _lstNVj;
        public RptDanhSachNhanVien(List<cNhanVienjoin> lstNVj)
        {
            InitializeComponent();
            this._lstNVj = lstNVj;
            this.DataSource = _lstNVj;
            LoadData();
          
        }
        void LoadData()
        {
            lblID.DataBindings.Add("Text", _lstNVj, "MaNV");
            lblHT.DataBindings.Add("Text", _lstNVj, "TenNV");
            lblGT.DataBindings.Add("Text", _lstNVj, "GioiTinh");
            lblNS.DataBindings.Add("Text", _lstNVj, "NgaySinh");
            lblDC.DataBindings.Add("Text", _lstNVj, "DiaChi");
            lblCCCD.DataBindings.Add("Text", _lstNVj, "CCCD");
            lblSDT.DataBindings.Add("Text", _lstNVj, "SDT");
            lblTD.DataBindings.Add("Text", _lstNVj, "TenTD");
        }

    }
}
