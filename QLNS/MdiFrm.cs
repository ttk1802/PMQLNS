using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Commonlib.TinhLuong;
using Commonlib;
using DevExpress.XtraSplashScreen;



namespace QLNS
{
    public partial class MdiFrm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public MdiFrm()
        {
            InitializeComponent();
        }
        FrmChucVu cv;
        FrmUngLuong ul;
        FrmTangCa tca;
        FrmNhanVien nv;
        FrmPhanCong pc;
        FrmPhongBan pb;
        FrmTrinhDo td;
        FrmBangLuong bl;
        FrmHopDong hd;
        FrmKTKL ktkl;
        FrmNV_ThoiViec nvtv;
        FrmLuongNV lnv;
        FrmBangChamCong ChamCong;
        FrmBangCong BangChamCong;
        Commonlib.TinhLuong.FrmPhuCap phucap;

        private void MdiFrm_Load(object sender, EventArgs e)
        {
            MdiFrm mdiChildForm = new MdiFrm();
            IsMdiContainer = true;
            if (lblCap.Caption =="")
            {
              


            }

            // Set the child form's MdiParent property to 
            // the current form.
         

        }
        void title()
        {
            if (panel1.Container == null)
            {
                lblCap.Caption = "";
            }
           
        }
        private void btnDN_Click(object sender, EventArgs e)
        {
            if (ConnectSql.succceed == false)
            {
                FrmLG frm = new FrmLG();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Bạn đã đăng nhập");
        }

        private void btnDMNV_Click(object sender, EventArgs e)
        {
            if (ConnectSql.succceed == false)
            {
                DialogResult result = MessageBox.Show("Vui lòng đăng nhập", "Thông báo", MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK)
                {
                    FrmLG frm = new FrmLG();
                    frm.ShowDialog();

                }
            }
            else
            {
                SplashScreenManager.ShowForm(typeof(FrmWait), true, true);
                if (nv==null)
                {
                    nv = new FrmNhanVien();
                    nv.Dock = DockStyle.Fill;
                    nv.TopLevel = false;
                    panel1.Controls.Add(nv);
                    nv.BringToFront();
                    nv.Show();
                }
                else
                {
                    nv.Close();
                    nv = new FrmNhanVien();
                    nv.Dock = DockStyle.Fill;
                    nv.TopLevel = false;
                    panel1.Controls.Add(nv);
                    nv.BringToFront();
                    nv.Show();
                }
               
               
                lblCap.Caption = "Danh mục nhân viên";
                SplashScreenManager.CloseForm();
            }

        }

    

        private void btnPban_Click(object sender, EventArgs e)
        {
            if (ConnectSql.succceed == false)
            {
                DialogResult result = MessageBox.Show("Vui lòng đăng nhập", "Thông báo", MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK)
                {
                    FrmLG frm = new FrmLG();
                    frm.ShowDialog();

                }
            }
            else
            {
                SplashScreenManager.ShowForm(typeof(FrmWait), true, true);
                if (pb==null)
                {
                    pb = new FrmPhongBan();
                    pb.TopLevel = false;
                    pb.Dock = DockStyle.Fill;
                    panel1.Controls.Add(pb);
                    pb.BringToFront();
                    pb.Show();
                }
                else
                {
                    pb.Dispose();
                    pb = new FrmPhongBan();

                    pb.TopLevel = false;
                    pb.Dock = DockStyle.Fill;
                    panel1.Controls.Add(pb);
                    pb.BringToFront();
                    pb.Show();

                }

                pb.Show();
                lblCap.Caption = "Danh mục phòng ban";
                SplashScreenManager.CloseForm();
            }

        }

        private void btnChucVu_Click(object sender, EventArgs e)
        {
            if (ConnectSql.succceed == false)
            {
                DialogResult result = MessageBox.Show("Vui lòng đăng nhập", "Thông báo", MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK)
                {
                    FrmLG frm = new FrmLG();
                    frm.ShowDialog();

                }
            }
            else
            {
                SplashScreenManager.ShowForm(typeof(FrmWait), true, true);
                if (cv == null)
                {
                    cv = new FrmChucVu();
                    cv.TopLevel = false;
                    cv.Dock = DockStyle.Fill;
                    panel1.Controls.Add(cv);
                    cv.BringToFront();
                    cv.Show();
                }
                else
                {
                    cv.Dispose();
                    cv = new FrmChucVu();
                    cv.TopLevel = false;
                    cv.Dock = DockStyle.Fill;
                    panel1.Controls.Add(cv);
                    cv.BringToFront();
                    cv.Show();
                }
                lblCap.Caption = "Danh mục chức vụ";
                SplashScreenManager.CloseForm();
            }
        }

        private void btnTrinhDo_Click(object sender, EventArgs e)
        {
            if (ConnectSql.succceed == false)
            {
                DialogResult result = MessageBox.Show("Vui lòng đăng nhập", "Thông báo", MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK)
                {
                    FrmLG frm = new FrmLG();
                    frm.ShowDialog();

                }
            }
            else
            {
                SplashScreenManager.ShowForm(typeof(FrmWait), true, true);
                if (td==null)
                {
                    td = new FrmTrinhDo();
                    td.TopLevel = false;
                    td.Dock = DockStyle.Fill;

                    panel1.Controls.Add(td);
                    td.BringToFront();
                    td.Show();
                }
                else
                {
                    td.Dispose();
                    td = new FrmTrinhDo();
                    td.TopLevel = false;
                    td.Dock = DockStyle.Fill;
                    panel1.Controls.Add(td);
                    td.BringToFront();
                    td.Show();
                }

                lblCap.Caption = "Danh mục trình độ";
                SplashScreenManager.CloseForm();
            }
          
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            if (ConnectSql.succceed == false)
            {
                DialogResult result = MessageBox.Show("Vui lòng đăng nhập", "Thông báo", MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK)
                {
                    FrmLG frm = new FrmLG();
                    frm.ShowDialog();

                }
            }
            else
            {
                SplashScreenManager.ShowForm(typeof(FrmWait), true, true);
                if (pc==null)
                {
                    pc = new FrmPhanCong();
                    pc.TopLevel = false;
                    pc.Dock = DockStyle.Fill;
                    panel1.Controls.Add(pc);
                    pc.BringToFront();
                    pc.Show();
                }
                else
                {
                    pc.Dispose();
                    pc = new FrmPhanCong();
                    pc.TopLevel = false;
                    pc.Dock = DockStyle.Fill;
                    panel1.Controls.Add(pc);
                    pc.BringToFront();
                    pc.Show();
                }

                lblCap.Caption = "Danh mục phân công";
                SplashScreenManager.CloseForm();
            }
           
            }


        private void btnDX_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn đăng xuất", "Thông báo", MessageBoxButtons.OKCancel,
               MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                if (ConnectSql.succceed == true)
                {
                    ConnectSql.Disconnect();
                    ConnectSql.succceed = false;
                    MessageBox.Show("Bạn đã đăng xuất");
                }
                else
                    MessageBox.Show("Bạn chưa đăng nhập");

            }
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            if (ConnectSql.succceed == false)
            {
                DialogResult result = MessageBox.Show("Vui lòng đăng nhập", "Thông báo", MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK)
                {
                    FrmLG frm = new FrmLG();
                    frm.ShowDialog();

                }
            }
            else
            {
                SplashScreenManager.ShowForm(typeof(FrmWait), true, true);
                if (ChamCong == null)
                {
                    ChamCong = new FrmBangChamCong();
                    ChamCong.TopLevel = false;
                    ChamCong.Dock = DockStyle.Fill;
                    panel1.Controls.Add(ChamCong);
                    ChamCong.BringToFront();
                    ChamCong.Show();
                }
                else
                {
                    ChamCong.Dispose();
                    ChamCong = new FrmBangChamCong();
                    ChamCong.TopLevel = false;
                    ChamCong.Dock = DockStyle.Fill;
                    panel1.Controls.Add(ChamCong);
                    ChamCong.BringToFront();
                    ChamCong.Show();
                }

                lblCap.Caption = "Chấm công";
                SplashScreenManager.CloseForm();
            }


        }

        private void btnBangCong_Click(object sender, EventArgs e)
        {
            if (ConnectSql.succceed == false)
            {
                DialogResult result = MessageBox.Show("Vui lòng đăng nhập", "Thông báo", MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK)
                {
                    FrmLG frm = new FrmLG();
                    frm.ShowDialog();

                }
            }
            else
            {
                SplashScreenManager.ShowForm(typeof(FrmWait), true, true);
                if (BangChamCong == null)
                {
                    BangChamCong = new FrmBangCong();
                    BangChamCong.TopLevel = false;
                    BangChamCong.Dock = DockStyle.Fill;
                    panel1.Controls.Add(BangChamCong);
                    BangChamCong.BringToFront();
                    BangChamCong.Show();
                }
                else
                {
                    BangChamCong.Dispose();
                    BangChamCong = new FrmBangCong();
                    BangChamCong.TopLevel = false;
                    BangChamCong.Dock = DockStyle.Fill;
                    panel1.Controls.Add(BangChamCong);
                    BangChamCong.BringToFront();
                    BangChamCong.Show();
                }

                lblCap.Caption = "Bảng công";
                SplashScreenManager.CloseForm();
            }
        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            if (ConnectSql.succceed == false)
            {
                DialogResult result = MessageBox.Show("Vui lòng đăng nhập", "Thông báo", MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK)
                {
                    FrmLG frm = new FrmLG();
                    frm.ShowDialog();

                }
            }
            else
            {
                SplashScreenManager.ShowForm(typeof(FrmWait), true, true);
                if (hd == null)
                {
                    hd = new FrmHopDong();
                    hd.TopLevel = false;
                    hd.Dock = DockStyle.Fill;
                    panel1.Controls.Add(hd);
                    hd.BringToFront();
                    hd.Show();
                }
                else
                {
                    hd.Dispose();
                    hd = new FrmHopDong();
                    hd.TopLevel = false;
                    hd.Dock = DockStyle.Fill;
                    panel1.Controls.Add(hd);
                    hd.BringToFront();
                    hd.Show();
                }

                lblCap.Caption = "Danh mục hợp đồng";
                SplashScreenManager.CloseForm();
            }
        }

        private void btnPCNV_Click(object sender, EventArgs e)
        {
            if (ConnectSql.succceed == false)
            {
                DialogResult result = MessageBox.Show("Vui lòng đăng nhập", "Thông báo", MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK)
                {
                    FrmLG frm = new FrmLG();
                    frm.ShowDialog();

                }
            }
            else
            {
                SplashScreenManager.ShowForm(typeof(FrmWait), true, true);
                if (phucap == null)
                {
                    phucap = new Commonlib.TinhLuong.FrmPhuCap();
                    phucap.TopLevel = false;
                    phucap.Dock = DockStyle.Fill;
                    panel1.Controls.Add(phucap);
                    phucap.BringToFront();
                    phucap.Show();
                }
                else
                {
                    phucap.Dispose();
                    phucap = new Commonlib.TinhLuong.FrmPhuCap();
                    phucap.TopLevel = false;
                    phucap.Dock = DockStyle.Fill;
                    panel1.Controls.Add(phucap);
                    phucap.BringToFront();
                    phucap.Show();
                }

                lblCap.Caption = "Danh mục phụ cấp";
                SplashScreenManager.CloseForm();
            }
        }

        private void btnUngLuong_Click(object sender, EventArgs e)
        {
            if (ConnectSql.succceed == false)
            {
                DialogResult result = MessageBox.Show("Vui lòng đăng nhập", "Thông báo", MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK)
                {
                    FrmLG frm = new FrmLG();
                    frm.ShowDialog();

                }
            }
            else
            {
                SplashScreenManager.ShowForm(typeof(FrmWait), true, true);
                if (ul == null)
                {
                    ul = new Commonlib.TinhLuong.FrmUngLuong();
                    ul.TopLevel = false;
                    ul.Dock = DockStyle.Fill;
                    panel1.Controls.Add(ul);
                  ul.BringToFront();
                  ul.Show();
                }
                else
                {
                    ul.Dispose();
                 ul = new Commonlib.TinhLuong.FrmUngLuong();
                 ul.TopLevel = false;
                 ul.Dock = DockStyle.Fill;
                    panel1.Controls.Add(ul);
                    ul.BringToFront();
                   ul.Show();
                }

                lblCap.Caption = "Danh mục ứng lương";
                SplashScreenManager.CloseForm();
            }
        }

        private void btnTangCa_Click(object sender, EventArgs e)
        {
            if (ConnectSql.succceed == false)
            {
                DialogResult result = MessageBox.Show("Vui lòng đăng nhập", "Thông báo", MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK)
                {
                    FrmLG frm = new FrmLG();
                    frm.ShowDialog();

                }
            }
            else
            {
                SplashScreenManager.ShowForm(typeof(FrmWait), true, true);
                if (tca == null)
                {
                    tca = new FrmTangCa();
                    tca.TopLevel = false;
                    tca.Dock = DockStyle.Fill;
                    panel1.Controls.Add(tca);
                    tca.BringToFront();
                    tca.Show();
                }
                else
                {
                    tca.Dispose();
                    tca = new FrmTangCa();
                    tca.TopLevel = false;
                    tca.Dock = DockStyle.Fill;
                    panel1.Controls.Add(tca);
                    tca.BringToFront();
                    tca.Show();
                }

                lblCap.Caption = "Danh mục tăng ca";
                SplashScreenManager.CloseForm();
            }
        }

        private void btnNVTV_Click(object sender, EventArgs e)
        {
            if (ConnectSql.succceed == false)
            {
                DialogResult result = MessageBox.Show("Vui lòng đăng nhập", "Thông báo", MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK)
                {
                    FrmLG frm = new FrmLG();
                    frm.ShowDialog();

                }
            }
            else
            {
                SplashScreenManager.ShowForm(typeof(FrmWait), true, true);
                if (nvtv == null)
                {
                    nvtv = new FrmNV_ThoiViec();
                    nvtv.TopLevel = false;
                    nvtv.Dock = DockStyle.Fill;
                    panel1.Controls.Add(nvtv);
                    nvtv.BringToFront();
                    nvtv.Show();
                }
                else
                {
                    nvtv.Dispose();
                    nvtv = new FrmNV_ThoiViec();
                    nvtv.TopLevel = false;
                    nvtv.Dock = DockStyle.Fill;
                    panel1.Controls.Add(nvtv);
                    nvtv.BringToFront();
                    nvtv.Show();
                }

                lblCap.Caption = "Danh mục thôi việc";
                SplashScreenManager.CloseForm();
            }
        }

        private void btnTienLuong_Click(object sender, EventArgs e)
        {
            if (ConnectSql.succceed == false)
            {
                DialogResult result = MessageBox.Show("Vui lòng đăng nhập", "Thông báo", MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK)
                {
                    FrmLG frm = new FrmLG();
                    frm.ShowDialog();

                }
            }
            else
            {
                SplashScreenManager.ShowForm(typeof(FrmWait), true, true);
                if (lnv == null)
                {
                    lnv = new FrmLuongNV();
                    lnv.TopLevel = false;
                    lnv.Dock = DockStyle.Fill;
                    panel1.Controls.Add(lnv);
                    lnv.BringToFront();
                    lnv.Show();
                }
                else
                {
                    lnv.Dispose();
                    lnv = new FrmLuongNV();
                    lnv.TopLevel = false;
                    lnv.Dock = DockStyle.Fill;
                    panel1.Controls.Add(lnv);
                    lnv.BringToFront();
                    lnv.Show();
                }

                lblCap.Caption = "Danh mục lương";
                SplashScreenManager.CloseForm();
            }
        }

        private void btnKTKL_Click(object sender, EventArgs e)
        {
            if (ConnectSql.succceed == false)
            {
                DialogResult result = MessageBox.Show("Vui lòng đăng nhập", "Thông báo", MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK)
                {
                    FrmLG frm = new FrmLG();
                    frm.ShowDialog();

                }
            }
            else
            {
                SplashScreenManager.ShowForm(typeof(FrmWait), true, true);
                if (ktkl == null)
                {
                    ktkl = new FrmKTKL();
                    ktkl.TopLevel = false;
                    ktkl.Dock = DockStyle.Fill;
                    panel1.Controls.Add(ktkl);
                    ktkl.BringToFront();
                    ktkl.Show();
                }
                else
                {
                    ktkl.Dispose();
                  ktkl = new FrmKTKL();
                  ktkl.TopLevel = false;
                    ktkl.Dock = DockStyle.Fill;
                    panel1.Controls.Add(ktkl);
                    ktkl.BringToFront();
                    ktkl.Show();
                }

                lblCap.Caption = "Danh mục khen thưởng kỷ luật";
                SplashScreenManager.CloseForm();
            }
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            if (ConnectSql.succceed == false)
            {
                DialogResult result = MessageBox.Show("Vui lòng đăng nhập", "Thông báo", MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK)
                {
                    FrmLG frm = new FrmLG();
                    frm.ShowDialog();

                }
            }
            else
            {
                SplashScreenManager.ShowForm(typeof(FrmWait), true, true);
                if (bl == null)
                {
                    bl = new FrmBangLuong();
                    bl.TopLevel = false;
                    bl.Dock = DockStyle.Fill;
                    panel1.Controls.Add(bl);
                    bl.BringToFront();
                    bl.Show();
                }
                else
                {
                    bl.Dispose();
                    bl = new FrmBangLuong();
                    bl.TopLevel = false;
                    bl.Dock = DockStyle.Fill;
                    panel1.Controls.Add(bl);
                    bl.BringToFront();
                    bl.Show();
                }

                lblCap.Caption = "Bảng lương";
                SplashScreenManager.CloseForm();
            }
        }

     

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            title();
        }

     
    }
}
