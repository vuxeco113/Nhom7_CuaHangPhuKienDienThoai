using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace frmMain
{
        public partial class frmLogin : Form
        {
          
            public frmLogin()
            {
                InitializeComponent();
            }

            private void frmLogin_Load(object sender, EventArgs e)
            {
                   
            }

            private void btnDangNhap_Click(object sender, EventArgs e)
            {
                List<User> users = new List<User>();
                string conStr = "Data Source=DESKTOP-JARJMT7\\SA;Initial Catalog=Nhom7_CuaHangPhuKienDienThoai;User ID=sa;Password=123";
                SqlConnection conn = new SqlConnection(conStr);
                conn.Open();
                string sql = "select * from NHANVIEN";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
           
                while (reader.Read())
                {
                    string x=reader["TENNV"].ToString();
                    string y= reader["MATKHAU"].ToString();
                    string z= reader["PHANQUYEN"].ToString();
                    User user = new User(x,y,z);
                    users.Add(user);
                }
                conn.Close();
            
                foreach (User tmp in users)
                {
                    if (tmp.TENNV == txtUserName.Text && int.Parse(tmp.MATKHAU) == int.Parse(txtPassWord.Text))
                    {
                       
                        MessageBox.Show("Đăng Nhập Thành Công "+tmp.TENNV);
                        frmMain mainForm = new frmMain(tmp.TENNV, tmp.MATKHAU, tmp.PHANQUYEN);
                       
                        mainForm.ShowDialog();
                        txtUserName.Clear();
                        txtPassWord.Clear();
                    }

                }
            }
        }
}
