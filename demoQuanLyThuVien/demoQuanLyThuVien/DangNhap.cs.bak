using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoQuanLyThuVien
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
            txtPassword.Text = "";
            txtPassword.PasswordChar = '*';
        }
        String user = "ngothuythuong.dacn";
        String pass = "123456789";

        private void button1_Click(object sender, EventArgs e)
        {
             if (txtTaiKhoan.Text == user )
            {
                if (txtPassword.Text == pass)
                {
                    this.Hide();
                    TrangChu tc = new TrangChu();
                    tc.ShowDialog();
                }
                else
                    MessageBox.Show("Mật khẩu không đúng!!!");
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại!!! ");
            }
        }
    }
}
