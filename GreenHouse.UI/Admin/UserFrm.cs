using FluentValidation;
using GreenHouse.BLL.Logic;
using GreenHouse.UI.User;
using GreenHouse.VM;
using GreenHouse.VM.Page;
using GreenHouse.VM.User;
using GreenHouse.VM.Validation;
using Guna.UI2.WinForms;
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
    public partial class UserFrm : Form
    {
        private readonly UserManager _userManager;
        private readonly RoleManager _roleManager;
        protected List<string> permissions;

        public UserFrm()
        {
            InitializeComponent();
            _userManager = new UserManager();
            _roleManager = new RoleManager();
        }

        public UserFrm(List<string> yetkiler):this()
        {
            permissions = yetkiler;       
            
        }

        private void UserFrm_Load(object sender, EventArgs e)
        {
            btnEkle.Tag = "Insert";
            btnSil.Tag = "Delete";
            btnGuncelle.Tag = "Update";
            buttonControl();
            cmbRol.Items.AddRange(_roleManager.GetRole().ToArray());
            Yenile();
        }

        private void Yenile()
        {
            lstKullanicilar.Items.Clear();
            lstKullanicilar.Items.AddRange(_userManager.GetUser().ToArray());
        }

        private void buttonControl()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Guna2Button button)
                {
                    Guna2Button btn = (Guna2Button)control;

                    if (permissions.Contains(btn.Tag.ToString()))
                    {
                        btn.Enabled = true;
                    }
                    else
                    {
                        btn.Enabled = false;
                    }
                }
            }
        }

        private void lstKullanicilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserSelectVM user = lstKullanicilar.SelectedItem as UserSelectVM;
            if (user != null)
            {
                txtAdi.Text = user.Adi;
                txtSoyadi.Text = user.Soyadi;
                txtEposta.Text = user.Email;
                cmbRol.SelectedItem = user.Rol;
                cmbRol.Text = user.Rol.RolAdi;
                chkAktifMi.Checked = user.AktifMi.HasValue ? user.AktifMi.Value:false;
                chkEmailOnay.Checked = user.EmailOnayliMi.HasValue ? user.EmailOnayliMi.Value : false;
                chkAdminOnay.Checked = user.AdminOnaylimi;
                chkPremium.Checked = user.PremiumMu;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            UserInsertVM user = new UserInsertVM { Adi = txtAdi.Text, Soyadi = txtSoyadi.Text, Email = txtEposta.Text, PasswordHash= txtSifre.Text, Rol = cmbRol.SelectedItem as RoleSelectVM, AktifMi = chkAktifMi.Checked, EmailOnayliMi=chkEmailOnay.Checked };

            UserInsertVMValidator validator = new UserInsertVMValidator();
            var result = validator.Validate(user);

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

            _userManager.AddUser(user);

            MessageBox.Show("Kullanıcı eklendi");
            Yenile();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            UserSelectVM user = lstKullanicilar.SelectedItem as UserSelectVM;

            if (user != null) 
            {
                user.Adi = txtAdi.Text;
                user.Soyadi = txtSoyadi.Text;
                user.Email = txtEposta.Text;
                user.PasswordHash = txtSifre.Text;
                user.Rol = cmbRol.SelectedItem as RoleSelectVM;
                user.EmailOnayliMi = chkEmailOnay.Checked;
                user.AktifMi = chkAktifMi.Checked;
                user.AdminOnaylimi = chkAdminOnay.Checked;
                user.PremiumMu = chkPremium.Checked;

                UserSelectVMValidator validator = new UserSelectVMValidator();
                var result = validator.Validate(user);

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

                _userManager.UpdateUser(user);
                MessageBox.Show("Kullanıcı güncellendi");
                Yenile();
                return;
            }
            MessageBox.Show("Kullanıcı seçin");

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            UserSelectVM user = lstKullanicilar.SelectedItem as UserSelectVM;

            if (user != null)
            {
                user.Adi = txtAdi.Text;
                user.Soyadi = txtSoyadi.Text;
                user.Email = txtEposta.Text;
                user.PasswordHash = txtSifre.Text;
                //user.Rol = cmbRol.SelectedItem as RoleSelectVM;
                user.EmailOnayliMi = chkEmailOnay.Checked;
                user.AktifMi = chkAktifMi.Checked;

                UserSelectVMValidator validator = new UserSelectVMValidator();
                var result = validator.Validate(user);

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

                _userManager.DeleteUser(user);

                MessageBox.Show("Kullanıcı silindi");
                Yenile();
                return;
            }
            MessageBox.Show("Kullanıcı seçin");
        }
    }
}
