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

namespace Commonlib
{
    public partial class FrmLG : DevExpress.XtraEditors.XtraForm
    {
        public FrmLG()
        {
            InitializeComponent();
        }

        private void FrmLG_Load(object sender, EventArgs e)
        {
            txtTennd.Text = "sa";
            txtMK.Text = "123";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn không muốn đăng nhập nữa?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            if (ConnectSql.Connect(txtTennd.Text, txtMK.Text))
            {
                ConnectSql.succceed = true;
                this.Close();
            }
        }
    }
}