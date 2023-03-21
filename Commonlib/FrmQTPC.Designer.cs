namespace Commonlib
{
    partial class FrmQTPC
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
            this.gcPC = new DevExpress.XtraGrid.GridControl();
            this.gvPC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPC)).BeginInit();
            this.SuspendLayout();
            // 
            // gcPC
            // 
            this.gcPC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPC.Location = new System.Drawing.Point(0, 0);
            this.gcPC.MainView = this.gvPC;
            this.gcPC.Name = "gcPC";
            this.gcPC.Size = new System.Drawing.Size(659, 297);
            this.gcPC.TabIndex = 2;
            this.gcPC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPC});
            // 
            // gvPC
            // 
            this.gvPC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn8,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn10,
            this.gridColumn9,
            this.gridColumn6,
            this.gridColumn7});
            this.gvPC.GridControl = this.gcPC;
            this.gvPC.Name = "gvPC";
            this.gvPC.OptionsFind.AlwaysVisible = true;
            this.gvPC.OptionsFind.Behavior = DevExpress.XtraEditors.FindPanelBehavior.Filter;
            this.gvPC.OptionsFind.FindDelay = 800;
            this.gvPC.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gvPC.OptionsFind.FindNullPrompt = "Nhập để tìm kiếm";
            this.gvPC.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.GroupPanel;
            this.gvPC.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã phân công";
            this.gridColumn1.FieldName = "MaPC";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Tên phân công";
            this.gridColumn8.FieldName = "TenPC";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mã phòng ban";
            this.gridColumn2.FieldName = "MaPB";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tên phòng ban";
            this.gridColumn3.FieldName = "TenPB";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Mã chức vụ";
            this.gridColumn4.FieldName = "MaCV";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Tên chức vụ";
            this.gridColumn5.FieldName = "TenCV";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Mã nhân viên";
            this.gridColumn10.FieldName = "MaNV";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 2;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Tên nhân viên";
            this.gridColumn9.FieldName = "TenNV";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Trạng thái";
            this.gridColumn6.FieldName = "TrangThai";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Thời gian";
            this.gridColumn7.FieldName = "ThoiGian";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            // 
            // FrmQTPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 297);
            this.Controls.Add(this.gcPC);
            this.Name = "FrmQTPC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qúa trình phân công";
            this.Load += new System.EventHandler(this.FrmQTPC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcPC;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPC;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
    }
}