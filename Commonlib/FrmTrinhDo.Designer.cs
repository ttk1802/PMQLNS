namespace Commonlib
{
    partial class FrmTrinhDo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrinhDo));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnDung = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.btnAnTT = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.btnTK = new DevExpress.XtraBars.BarButtonItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtTenTD = new System.Windows.Forms.TextBox();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ten = new DevExpress.XtraLayout.LayoutControlItem();
            this.gcTD = new DevExpress.XtraGrid.GridControl();
            this.gvTD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTD)).BeginInit();
            this.SuspendLayout();
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
            this.btnAnTT});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDung, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnIn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAnTT)});
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
            this.btnIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnIn_ItemClick);
            // 
            // btnAnTT
            // 
            this.btnAnTT.Caption = "Ẩn thông tin";
            this.btnAnTT.Id = 9;
            this.btnAnTT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAnTT.ImageOptions.Image")));
            this.btnAnTT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAnTT.ImageOptions.LargeImage")));
            this.btnAnTT.Name = "btnAnTT";
            this.btnAnTT.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAnTT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAnTT_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(713, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 392);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(713, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 368);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl2.Location = new System.Drawing.Point(713, 24);
            this.barDockControl2.Manager = this.barManager1;
            this.barDockControl2.Size = new System.Drawing.Size(0, 368);
            // 
            // btnTK
            // 
            this.btnTK.Caption = "Tìm kiếm";
            this.btnTK.Id = 5;
            this.btnTK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTK.ImageOptions.SvgImage")));
            this.btnTK.Name = "btnTK";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcTD);
            this.splitContainer1.Size = new System.Drawing.Size(713, 368);
            this.splitContainer1.SplitterDistance = 65;
            this.splitContainer1.TabIndex = 5;
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSize = true;
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(713, 65);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Thông tin trình độ";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtTenTD);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 23);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(709, 40);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtTenTD
            // 
            this.txtTenTD.Location = new System.Drawing.Point(73, 12);
            this.txtTenTD.Name = "txtTenTD";
            this.txtTenTD.Size = new System.Drawing.Size(607, 20);
            this.txtTenTD.TabIndex = 6;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.ten});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(692, 54);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(672, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ten
            // 
            this.ten.Control = this.txtTenTD;
            this.ten.Location = new System.Drawing.Point(0, 0);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(672, 24);
            this.ten.Text = "Tên trình độ";
            this.ten.TextSize = new System.Drawing.Size(58, 13);
            // 
            // gcTD
            // 
            this.gcTD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTD.Location = new System.Drawing.Point(0, 0);
            this.gcTD.MainView = this.gvTD;
            this.gcTD.MenuManager = this.barManager1;
            this.gcTD.Name = "gcTD";
            this.gcTD.Size = new System.Drawing.Size(713, 299);
            this.gcTD.TabIndex = 3;
            this.gcTD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTD});
            // 
            // gvTD
            // 
            this.gvTD.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gvTD.GridControl = this.gcTD;
            this.gvTD.Name = "gvTD";
            this.gvTD.OptionsFind.AlwaysVisible = true;
            this.gvTD.OptionsFind.Behavior = DevExpress.XtraEditors.FindPanelBehavior.Filter;
            this.gvTD.OptionsFind.FindDelay = 800;
            this.gvTD.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gvTD.OptionsFind.FindNullPrompt = "Nhập để tìm kiếm";
            this.gvTD.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.GroupPanel;
            this.gvTD.OptionsView.ShowGroupPanel = false;
            this.gvTD.Click += new System.EventHandler(this.gvTD_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã trình độ";
            this.gridColumn1.FieldName = "MaTD";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 45;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên trình độ";
            this.gridColumn2.FieldName = "TenTD";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 643;
            // 
            // FrmTrinhDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 392);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmTrinhDo";
            this.Text = "Danh mục trình độ";
            this.Load += new System.EventHandler(this.FrmTrinhDo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnDung;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraBars.BarButtonItem btnAnTT;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarButtonItem btnTK;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private System.Windows.Forms.TextBox txtTenTD;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem ten;
        private DevExpress.XtraGrid.GridControl gcTD;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTD;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}