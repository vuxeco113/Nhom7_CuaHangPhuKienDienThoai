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
    public partial class frmMain : Form
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string PhanCap { get; set; }
        public frmMain(string userName, string passWord, string phanCap)
        {
            InitializeComponent();
            UserName = userName;
            PassWord = passWord;
            PhanCap = phanCap;
            MessageBox.Show($"Chào {UserName}, Phân cấp: {PhanCap}");
        }

        private void DangXuat_Menu_Click(object sender, EventArgs e)
        {
            this.Close(); // Optionally close the main form
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Chào " + UserName;
            toolStripStatusLabel2.Text = PhanCap;
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DoiMtKhau_Menu_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau(PassWord, UserName);
            frm.Show();
        }
    }
}
