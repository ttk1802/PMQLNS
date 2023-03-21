namespace Commonlib
{
    partial class FrmTimKiemNV
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
            this.gcNV = new DevExpress.XtraGrid.GridControl();
            this.gvNV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNV)).BeginInit();
            this.SuspendLayout();
            // 
            // gcNV
            // 
            this.gcNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcNV.Location = new System.Drawing.Point(0, 0);
            this.gcNV.MainView = this.gvNV;
            this.gcNV.Name = "gcNV";
            this.gcNV.Size = new System.Drawing.Size(809, 551);
            this.gcNV.TabIndex = 3;
            this.gcNV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNV});
            // 
            // gvNV
            // 
            this.gvNV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12});
            this.gvNV.GridControl = this.gcNV;
            this.gvNV.Name = "gvNV";
            this.gvNV.OptionsFind.AlwaysVisible = true;
            this.gvNV.OptionsFind.Behavior = DevExpress.XtraEditors.FindPanelBehavior.Filter;
            this.gvNV.OptionsFind.FindDelay = 800;
            this.gvNV.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gvNV.OptionsFind.FindNullPrompt = "Nhập để tìm kiếm";
            this.gvNV.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.GroupPanel;
            this.gvNV.OptionsView.ShowGroupPanel = false;
            this.gvNV.Click += new System.EventHandler(this.gvNV_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã nhân viên";
            this.gridColumn1.FieldName = "MaNV";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên nhân viên";
            this.gridColumn2.FieldName = "TenNV";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Giới tính";
            this.gridColumn3.FieldName = "GioiTinh";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Ngày sinh";
            this.gridColumn4.FieldName = "NgaySinh";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Điện thoại";
            this.gridColumn5.FieldName = "SDT";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Địa chỉ";
            this.gridColumn6.FieldName = "DiaChi";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "CCCD/CMND";
            this.gridColumn7.FieldName = "CCCD";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Hình ảnh";
            this.gridColumn8.FieldName = "HinhAnh";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Mã trình độ";
            this.gridColumn9.FieldName = "MaTD";
            this.gridColumn9.Name = "gridColumn9";
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Trình độ";
            this.gridColumn10.FieldName = "TenTD";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 8;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Mã phân công";
            this.gridColumn11.FieldName = "MaPC";
            this.gridColumn11.Name = "gridColumn11";
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Tên phân công";
            this.gridColumn12.FieldName = "TenPC";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 9;
            // 
            // FrmTimKiemNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 551);
            this.Controls.Add(this.gcNV);
            this.Name = "FrmTimKiemNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm nhân viên";
            this.Load += new System.EventHandler(this.FrmTimKiemNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcNV;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNV;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
    }
}