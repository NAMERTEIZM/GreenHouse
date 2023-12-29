using GreenHouse.BLL.Admin;
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

namespace GreenHouse.UI.User
{
    public partial class UserRegisterFrm : Form
    {
        private readonly LoginManager _loginManager;

        public UserRegisterFrm()
        {
            InitializeComponent();
            _loginManager = new LoginManager();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {


            if (!chkKullanimSartlari.Checked)
            {
                MessageBox.Show("Kullanım şartlarını onaylamadan kayıt olamazsınız.");
                return;
            }

            UserVM uservm = new UserVM
            {
                Adi = txtAdi.Text,
                Soyadi = txtSoyadi.Text,
                Email = txtEposta.Text,
                PasswordHash = txtSifre.Text
            };

            UserVMValidator validator = new UserVMValidator();
            var result = validator.Validate(uservm);

            if (!result.IsValid)
            {
                string hatalar = "";
                foreach (var error in result.Errors)
                {
                    hatalar += error.ErrorMessage + "\n";                  
                }
                MessageBox.Show(hatalar);
                return;
            }

            if (txtSifre.Text != txtSifreTekrar.Text)
            {
                MessageBox.Show("Şifreler uyuşmuyor.");
                return;
            }

            if (_loginManager.UserRegister(uservm))
            {
                MessageBox.Show("Başarıyla kayıt oldunuz.");
                UserLoginFrm userLoginFrm = new UserLoginFrm();
                userLoginFrm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bu kullanıcı zaten var veya bir hata oluştu!");
            }
        }

        private void btnGirisSayfasinaDon_Click(object sender, EventArgs e)
        {
            UserLoginFrm userLoginFrm = new UserLoginFrm();
            userLoginFrm.Show();
            this.Close();
        }
    }
}
