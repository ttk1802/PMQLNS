namespace Commonlib
{
    partial class FrmCapNhatNgayCong
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
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.mcldNCC = new System.Windows.Forms.MonthCalendar();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.rdgChamCong = new DevExpress.XtraEditors.RadioGroup();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.rdgThoiGian = new DevExpress.XtraEditors.RadioGroup();
            this.btnDong = new System.Windows.Forms.Button();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.lblHT = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdgChamCong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdgThoiGian.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCapNhat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCapNhat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnCapNhat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(178, 218);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(90, 30);
            this.btnCapNhat.TabIndex = 0;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // mcldNCC
            // 
            this.mcldNCC.Location = new System.Drawing.Point(2, 2);
            this.mcldNCC.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.mcldNCC.MinDate = new System.DateTime(2002, 1, 1, 0, 0, 0, 0);
            this.mcldNCC.Name = "mcldNCC";
            this.mcldNCC.TabIndex = 1;
            this.mcldNCC.TitleBackColor = System.Drawing.Color.LightSeaGreen;
            this.mcldNCC.TrailingForeColor = System.Drawing.Color.LightSeaGreen;
            this.mcldNCC.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mcldNCC_DateSelected);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.rdgChamCong);
            this.groupControl1.Location = new System.Drawing.Point(177, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(187, 84);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Chấm công";
            // 
            // rdgChamCong
            // 
            this.rdgChamCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdgChamCong.EditValue = "V";
            this.rdgChamCong.Location = new System.Drawing.Point(2, 23);
            this.rdgChamCong.Name = "rdgChamCong";
            this.rdgChamCong.Properties.Columns = 2;
            this.rdgChamCong.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("P", "Nghỉ phép"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("V", "Vắng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("CT", "Công tác")});
            this.rdgChamCong.Size = new System.Drawing.Size(183, 59);
            this.rdgChamCong.TabIndex = 0;
            this.rdgChamCong.SelectedIndexChanged += new System.EventHandler(this.rdgChamCong_SelectedIndexChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.rdgThoiGian);
            this.groupControl2.Location = new System.Drawing.Point(177, 96);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(185, 106);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Thời gian nghỉ";
            // 
            // rdgThoiGian
            // 
            this.rdgThoiGian.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdgThoiGian.EditValue = "NN";
            this.rdgThoiGian.Location = new System.Drawing.Point(2, 23);
            this.rdgThoiGian.Name = "rdgThoiGian";
            this.rdgThoiGian.Properties.Columns = 2;
            this.rdgThoiGian.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("S", "Sáng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("C", "Chiều"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("NN", "Nguyên ngày")});
            this.rdgThoiGian.Size = new System.Drawing.Size(181, 81);
            this.rdgThoiGian.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDong.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnDong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(272, 218);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(90, 30);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.Controls.Add(this.lblHT);
            this.groupControl3.Controls.Add(this.lblID);
            this.groupControl3.Controls.Add(this.label2);
            this.groupControl3.Controls.Add(this.label1);
            this.groupControl3.Location = new System.Drawing.Point(12, 176);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(159, 86);
            this.groupControl3.TabIndex = 4;
            this.groupControl3.Text = "Thông tin";
            // 
            // lblHT
            // 
            this.lblHT.AutoSize = true;
            this.lblHT.Location = new System.Drawing.Point(51, 57);
            this.lblHT.Name = "lblHT";
            this.lblHT.Size = new System.Drawing.Size(35, 13);
            this.lblHT.TabIndex = 3;
            this.lblHT.Text = "label4";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(51, 33);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(35, 13);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // FrmCapNhatNgayCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 272);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.mcldNCC);
            this.Controls.Add(this.btnCapNhat);
            this.Name = "FrmCapNhatNgayCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật ngày công";
            this.Load += new System.EventHandler(this.FrmCapNhatNgayCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdgChamCong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdgThoiGian.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.MonthCalendar mcldNCC;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.RadioGroup rdgChamCong;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.RadioGroup rdgThoiGian;
        private System.Windows.Forms.Button btnDong;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.Label lblHT;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}