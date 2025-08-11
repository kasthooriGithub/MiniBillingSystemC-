using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1stSemiProject
{
    public partial class loginfrm : Form
    {
        public loginfrm()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_User.Text == "admin" && txt_password.Text == "123")
            {
                mainfrm mainfrm = new mainfrm();
                this.Hide();
                mainfrm.Show();
            }
            else if (txt_User.Text != "admin" || txt_password.Text != "123")
            {
                MessageBox.Show("UserName or Password Incorrect,Please enter valid UserName or Password");
            }
        }
    }
}
