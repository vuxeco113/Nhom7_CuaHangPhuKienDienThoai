using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmMain
{
    
    public partial class frmDoiMatKhau : Form
    {
        public string passCu;
        public string ten;
        public frmDoiMatKhau(string pass, string ten1)
        {
            InitializeComponent();
            this.passCu = pass;
            this.ten = ten1;
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtPassWordCu.Text) != int.Parse(txtPassWordMoi.Text) && int.Parse(txtPassWordMoi.Text) == int.Parse(txtPassWordXacNhan.Text) && int.Parse(txtPassWordCu.Text) == int.Parse(passCu))
            {
                List<User> users = new List<User>();
                string conStr = "Data Source=DESKTOP-JARJMT7\\SA;Initial Catalog=Nhom7_CuaHangPhuKienDienThoai;User ID=sa;Password=123";
                SqlConnection conn = new SqlConnection(conStr);
                conn.Open();
                string sql = "update NHANVIEN set MATKHAU='" + txtPassWordXacNhan.Text + "' where TENNV=N'" + ten + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đổi mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Kiểm Tra lại");
            }
        }
    }
}
