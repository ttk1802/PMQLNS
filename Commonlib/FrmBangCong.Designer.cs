namespace Commonlib
{
    partial class FrmBangCong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBangCong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbTT = new System.Windows.Forms.CheckBox();
            this.ckbKhoa = new System.Windows.Forms.CheckBox();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.dgvBC = new System.Windows.Forms.DataGridView();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnDung = new DevExpress.XtraBars.BarButtonItem();
            this.btnChamCong = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.btnTK = new DevExpress.XtraBars.BarButtonItem();
            this.btnAnTT = new DevExpress.XtraBars.BarButtonItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ckbTT);
            this.panel1.Controls.Add(this.ckbKhoa);
            this.panel1.Controls.Add(this.cbThang);
            this.panel1.Controls.Add(this.cbNam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 41);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tháng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Năm";
            // 
            // ckbTT
            // 
            this.ckbTT.AutoSize = true;
            this.ckbTT.Location = new System.Drawing.Point(537, 14);
            this.ckbTT.Name = "ckbTT";
            this.ckbTT.Size = new System.Drawing.Size(75, 17);
            this.ckbTT.TabIndex = 3;
            this.ckbTT.Text = "Trạng thái";
            this.ckbTT.UseVisualStyleBackColor = true;
            // 
            // ckbKhoa
            // 
            this.ckbKhoa.AutoSize = true;
            this.ckbKhoa.Location = new System.Drawing.Point(467, 14);
            this.ckbKhoa.Name = "ckbKhoa";
            this.ckbKhoa.Size = new System.Drawing.Size(50, 17);
            this.ckbKhoa.TabIndex = 2;
            this.ckbKhoa.Text = "Khóa";
            this.ckbKhoa.UseVisualStyleBackColor = true;
            // 
            // cbThang
            // 
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbThang.Location = new System.Drawing.Point(314, 12);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(121, 21);
            this.cbThang.TabIndex = 1;
            // 
            // cbNam
            // 
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2022"});
            this.cbNam.Location = new System.Drawing.Point(113, 12);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(121, 21);
            this.cbNam.TabIndex = 0;
            // 
            // dgvBC
            // 
            this.dgvBC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBC.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBC.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBC.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvBC.Location = new System.Drawing.Point(0, 65);
            this.dgvBC.MultiSelect = false;
            this.dgvBC.Name = "dgvBC";
            this.dgvBC.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvBC.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBC.Size = new System.Drawing.Size(693, 247);
            this.dgvBC.TabIndex = 6;
            this.dgvBC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBC_CellClick);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControl2);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.btnLuu,
            this.btnDung,
            this.btnTK,
            this.btnThoat,
            this.btnIn,
            this.btnAnTT,
            this.btnChamCong});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 11;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDung, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnChamCong),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnIn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 3;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.LargeImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnDung
            // 
            this.btnDung.Caption = "Dừng";
            this.btnDung.Id = 4;
            this.btnDung.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDung.ImageOptions.SvgImage")));
            this.btnDung.Name = "btnDung";
            this.btnDung.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDung_ItemClick);
            // 
            // btnChamCong
            // 
            this.btnChamCong.Caption = "Chấm công";
            this.btnChamCong.Id = 10;
            this.btnChamCong.ImageOptions.SvgImage = global::Commonlib.Properties.Resources.adateoccuring1;
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnChamCong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChamCong_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Đóng";
            this.btnThoat.Id = 6;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // btnIn
            // 
            this.btnIn.Caption = "In danh sách";
            this.btnIn.Id = 7;
            this.btnIn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.ImageOptions.Image")));
            this.btnIn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnIn.ImageOptions.LargeImage")));
            this.btnIn.Name = "btnIn";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(693, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 312);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(693, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 288);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl2.Location = new System.Drawing.Point(693, 24);
            this.barDockControl2.Manager = this.barManager1;
            this.barDockControl2.Size = new System.Drawing.Size(0, 288);
            // 
            // btnTK
            // 
            this.btnTK.Caption = "Tìm kiếm";
            this.btnTK.Id = 5;
            this.btnTK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTK.ImageOptions.SvgImage")));
            this.btnTK.Name = "btnTK";
            // 
            // btnAnTT
            // 
            this.btnAnTT.Caption = "Ẩn thông tin";
            this.btnAnTT.Id = 9;
            this.btnAnTT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAnTT.ImageOptions.Image")));
            this.btnAnTT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAnTT.ImageOptions.LargeImage")));
            this.btnAnTT.Name = "btnAnTT";
            this.btnAnTT.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // FrmBangCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 312);
            this.Controls.Add(this.dgvBC);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmBangCong";
            this.Text = "Bảng công";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmBangCong_FormClosed);
            this.Load += new System.EventHandler(this.FrmBangCong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.CheckBox ckbKhoa;
        private System.Windows.Forms.DataGridView dgvBC;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnDung;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarButtonItem btnTK;
        private DevExpress.XtraBars.BarButtonItem btnAnTT;
        private System.Windows.Forms.CheckBox ckbTT;
        private DevExpress.XtraBars.BarButtonItem btnChamCong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}