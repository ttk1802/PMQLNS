using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commonlib
{
    public class ConnectSql
    {
     
        // Begin
        public static SqlConnection Con;  //Khai báo đối tượng kết nối       
        public static SqlDataAdapter adapter = null;
        public static DataSet ds = null;
        public static bool succceed = false;
        public static BindingSource bs = null;
        //public static string connstr = "Server=DESKTOP-GEASNU8;Database=DBAccounting;Integrated Security = True";
        public static bool Connect(string Uname, string Upw)
        {

            string connstr = "Server=DESKTOP-GEASNU8;Database=QL_NS;;User ID=" + Uname + ";Password=" + Upw;
            //  string connstr = "Server=SV12\\SQLEXPRESS;Database=QL_NhanSu;;User ID=" + Uname + ";Password=" + Upw;
            try
            {
                Con = new SqlConnection(connstr);   //Khởi tạo đối tượng
                Con.Open();                  //Mở kết nối
                                             //Kiểm tra kết nối
                if (Con.State == ConnectionState.Open)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    succceed = true;
                }
            }
            catch (Exception)
            {
                String message = "Thông tin không chính xác"; string title = "Thông báo";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return succceed;
        }
        public static void Disconnect()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();   	//Đóng kết nối
                Con.Dispose(); 	//Giải phóng tài nguyên
                Con = null;
            }
        }
        //Lấy dữ liệu vào bảng
        public static DataTable GetDataToTable(string sql)
        {
            adapter = new SqlDataAdapter(sql, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public static DataTable GetDataToTable1(string sql, string TABLE)
        {
            adapter = new SqlDataAdapter(sql, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, TABLE);
            return ds.Tables[TABLE];


        }
     
        public static bool RunSql = true;
        public static void RunSQL(string sql)
        {
            SqlCommand cmd; //Đối tượng thuộc lớp SqlCommand
            cmd = new SqlCommand();
            cmd.Connection = Con; //Gán kết nối
            cmd.CommandText = sql; //Gán lệnh SQL
            try
            {
                cmd.ExecuteNonQuery(); //Thực hiện câu lệnh SQL
                RunSql = true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                throw;
                RunSql = false;
            }
            cmd.Dispose();//Giải phóng bộ nhớ
            cmd = null;
        }

        public static void XoaNoiDung(Control ctrl)
        {
            if (ctrl is TextBox || ctrl is DateTimePicker || ctrl is DataGridView || ctrl is MaskedTextBox)
            {
                ctrl.Text = string.Empty;
            }
            foreach (Control i in ctrl.Controls)
            {
                XoaNoiDung(i);
            }
        }


        public static void LockControlValues(System.Windows.Forms.Control Container)
        {
            try
            {
                foreach (Control ctrl in Container.Controls)
                {
                    if (ctrl.GetType() == typeof(TextBox))
                        ((TextBox)ctrl).ReadOnly = true;

                    if (ctrl.GetType() == typeof(MaskedTextBox))
                        ((MaskedTextBox)ctrl).ReadOnly = true;
                    if (ctrl.Controls.Count > 0)
                        LockControlValues(ctrl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void UnLockControlValues(System.Windows.Forms.Control Container)
        {
            try
            {
                foreach (Control ctrl in Container.Controls)
                {
                    if (ctrl.GetType() == typeof(TextBox))
                        ((TextBox)ctrl).ReadOnly = false;

                    if (ctrl.GetType() == typeof(MaskedTextBox))
                        ((MaskedTextBox)ctrl).ReadOnly = false;
                    if (ctrl.Controls.Count > 0)
                        UnLockControlValues(ctrl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
