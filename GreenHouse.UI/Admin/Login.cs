using GreenHouse.BLL.Admin;
using GreenHouse.UI.User;
using GreenHouse.VM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenHouse.UI.Admin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            LoginManager lm = new LoginManager();

            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Lütfen boşlukları doldurun!");
                return;
            }

            UserVM user = new UserVM
            {
                Email = txtUsername.Text,
                PasswordHash = txtPassword.Text

            };

            Dictionary<string, List<string>> permissions = lm.Login(user);
            if (permissions!=null && !permissions.ContainsKey("Select"))
            {
                MessageBox.Show("Erişim yetkiniz yok!");
                return;
            }

            if (permissions!=null)
            {
                MainPage mp = new MainPage(permissions);
                mp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kulanıcı adı ve şifre yanlış!");
            };
        }

        private void btnKullanciGiris_Click(object sender, EventArgs e)
        {
            UserLoginFrm mp = new UserLoginFrm();
            mp.Show();
            this.Hide();
        }
    }
}
