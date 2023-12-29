using GreenHouse.BLL.Logic;
using GreenHouse.VM.Page;
using GreenHouse.VM.Role;
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
    public partial class RolFrm : Form
    {
        RoleManager _roleManager;
        public RolFrm()
        {
            InitializeComponent();
            _roleManager = new RoleManager();

        }

        protected List<string> permissions;
        public RolFrm(List<string> yetkiler) : this()
        {
            permissions = yetkiler;

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

        private void RolFrm_Load(object sender, EventArgs e)
        {
            Yenile();
            btnEkle.Tag = "Insert";
            btnSil.Tag = "Delete";
            btnGuncelle.Tag = "Update";
            buttonControl();
        }

        private void Yenile()
        {
            lstRoller.Items.Clear();
            lstRoller.Items.AddRange(_roleManager.GetRole().ToArray());
        }

        private void lstRoller_SelectedIndexChanged(object sender, EventArgs e)
        {
            RoleSelectVM roleSelectVM = lstRoller.SelectedItem as RoleSelectVM;
            if (roleSelectVM == null)
            {
                return;
            }
            txtRolAdi.Text = roleSelectVM.RolAdi.ToString();
            chkAktifMi.Checked = roleSelectVM.AktifMi.Value;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (txtRolAdi.Text == "")
            {
                MessageBox.Show("Lütfen rol adını giriniz!");
                return;
            }

            RoleInsertVM roleInsertVM = new RoleInsertVM { RolAdi = txtRolAdi.Text, AktifMi = chkAktifMi.Checked };
            _roleManager.AddRole(roleInsertVM);
            MessageBox.Show("Rol Eklendi");
            Yenile();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            RoleSelectVM roleSelectVM = lstRoller.SelectedItem as RoleSelectVM;

            if(txtRolAdi.Text == "")
            {
                MessageBox.Show("Lütfen rol adını giriniz!");
                return;
            }

            if (roleSelectVM == null)
            {
                MessageBox.Show("Lütfen bir rol seçiniz!");
                return;
            }

            roleSelectVM.RolAdi = txtRolAdi.Text;
            roleSelectVM.AktifMi = chkAktifMi.Checked;
            _roleManager.UpdateRole(roleSelectVM);
            MessageBox.Show("Rol Güncellendi");
            Yenile();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            RoleSelectVM roleSelectVM = lstRoller.SelectedItem as RoleSelectVM;

            if (roleSelectVM == null)
            {
                MessageBox.Show("Lütfen bir rol seçiniz!");
                return;
            }

            _roleManager.DeleteRole(roleSelectVM);
            MessageBox.Show("Rol Silindi");
            Yenile();
        }
    }
}

