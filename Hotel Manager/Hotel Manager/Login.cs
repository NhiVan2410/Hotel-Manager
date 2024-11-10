using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Manager
{
    public partial class Login : Form
    {
  
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            txtPassWord.PasswordChar = '*';
            string username = txtUserName.Text;
            string password = txtPassWord.Text;
            if (username == "test" && password == "123")
            {
                MessageBox.Show("Login successful !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(" Username or Password is correct !", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Hiện show passwoed lúc nnhaapj
            txtPassWord.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }
    }
}
