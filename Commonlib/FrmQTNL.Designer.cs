namespace Commonlib
{
    partial class FrmQTNL
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
            this.gcLnv = new DevExpress.XtraGrid.GridControl();
            this.gvLnv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.delete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcLnv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLnv)).BeginInit();
            this.SuspendLayout();
            // 
            // gcLnv
            // 
            this.gcLnv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLnv.Location = new System.Drawing.Point(0, 0);
            this.gcLnv.MainView = this.gvLnv;
            this.gcLnv.Name = "gcLnv";
            this.gcLnv.Size = new System.Drawing.Size(659, 297);
            this.gcLnv.TabIndex = 2;
            this.gcLnv.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLnv});
            // 
            // gvLnv
            // 
            this.gvLnv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.delete,
            this.gridColumn1,
            this.gridColumn10,
            this.gridColumn9,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn7});
            this.gvLnv.GridControl = this.gcLnv;
            this.gvLnv.Name = "gvLnv";
            this.gvLnv.OptionsFind.AlwaysVisible = true;
            this.gvLnv.OptionsFind.Behavior = DevExpress.XtraEditors.FindPanelBehavior.Filter;
            this.gvLnv.OptionsFind.FindDelay = 800;
            this.gvLnv.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gvLnv.OptionsFind.FindNullPrompt = "Nhập để tìm kiếm";
            this.gvLnv.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.GroupPanel;
            this.gvLnv.OptionsView.ShowGroupPanel = false;
            // 
            // delete
            // 
            this.delete.FieldName = "Deleteby";
            this.delete.MaxWidth = 20;
            this.delete.Name = "delete";
            this.delete.Visible = true;
            this.delete.VisibleIndex = 0;
            this.delete.Width = 20;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Mã nhân viên";
            this.gridColumn10.FieldName = "MaNV";
            this.gridColumn10.Name = "gridColumn10";
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Tên nhân viên";
            this.gridColumn9.FieldName = "TenNV";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Thời gian";
            this.gridColumn2.FieldName = "ThoiGian";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Lương cơ bản";
            this.gridColumn3.FieldName = "LCB";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Áp dụng";
            this.gridColumn7.FieldName = "TrangThai";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 4;
            // 
            // FrmQTNL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 297);
            this.Controls.Add(this.gcLnv);
            this.Name = "FrmQTNL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quá trình nâng lương";
            this.Load += new System.EventHandler(this.FrmQTNL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcLnv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLnv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcLnv;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLnv;
        private DevExpress.XtraGrid.Columns.GridColumn delete;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
    }
}