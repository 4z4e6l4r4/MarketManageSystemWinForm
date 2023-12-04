using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketYönetimSistemi
{
    public partial class LoginPanel : Form
    {
        public LoginPanel()
        {
            InitializeComponent();
        }

        // Admin Password = 1453
        // Username = Azra, Password = 1701

        // ----------------- LOGIN PARTS ----------------- 
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var password = PasswordTxt.Text;
            if (password == "1453")
            {
                AdminPanel adminPanel = new AdminPanel();
                this.Hide();
                adminPanel.Show();
            }
        }

        private void UserLoginBtn_Click(object sender, EventArgs e)
        {
            var user = UsernameTxt.Text;
            var userPassword = UserPasswordTxt.Text;
            if (user == "Azra" && userPassword == "1701")
            {
                UserPanel userPanel = new UserPanel();
                this.Hide();
                userPanel.Show();

            }

        }

  
    }
}
