using GreenHouse.BLL.Admin;
using GreenHouse.UI.Admin;
using GreenHouse.VM;
using GreenHouse.VM.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenHouse.UI.User
{
    public partial class UserLoginFrm : Form
    {
        private readonly LoginManager _loginManager;

        public UserLoginFrm()
        {
            InitializeComponent();
            _loginManager = new LoginManager();
        }

        private void btnKullanciGiris_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            UserDetailVM userDetailVM = _loginManager.UserLogin(new UserLoginVM { Email = txtUsername.Text, PasswordHash = txtPassword.Text });
            if (userDetailVM != null)
            {
                UserMainFrm userMainFrm = new UserMainFrm(userDetailVM);
                userMainFrm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UserRegisterFrm userRegisterFrm = new UserRegisterFrm();
            userRegisterFrm.Show();
            this.Hide();
        }
    }
}
