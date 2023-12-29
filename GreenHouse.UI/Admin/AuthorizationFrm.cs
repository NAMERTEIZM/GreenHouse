using GreenHouse.BLL.Logic;
using GreenHouse.VM.Authorizon;
using GreenHouse.VM.Company;
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
    public partial class AuthorizationFrm : Form
    {
        AuthorizonManager authorizonManager;

        public AuthorizationFrm()
        {
            InitializeComponent();
            authorizonManager = new AuthorizonManager();
        }

        protected List<string> permissions;
        public AuthorizationFrm(List<string> yetkiler) : this()
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

        private void AuthorizationFrm_Load(object sender, EventArgs e)
        {
            Yenile();
            btnEkle.Tag = "Insert";
            btnSil.Tag = "Delete";
            btnGuncelle.Tag = "Update";
            buttonControl();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtYetkiAdi.Text == "")
                {
                    MessageBox.Show("Lütfen yetki adını giriniz!");
                    return;
                }

                AuthorizonInsertVM auth = new AuthorizonInsertVM()
                {
                    Adi = txtYetkiAdi.Text
                };

                authorizonManager.AddAuthorizon(auth);
                MessageBox.Show("Yetki eklendi");
                Yenile();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata olustu ", ex.ToString());
                throw;
            }

        }

        private void Yenile()
        {
            lstYetkiler.Items.Clear();
            lstYetkiler.Items.AddRange(authorizonManager.GetAuthorizon().ToArray());
        }

        private void lstYetkiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            AuthorizonSelectVM clickedAuth = lstYetkiler.SelectedItem as AuthorizonSelectVM;
            if (clickedAuth != null)
            {
                txtYetkiAdi.Text = clickedAuth.Adi;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            try
            {
                if (lstYetkiler.SelectedItems == null)
                {
                    MessageBox.Show("Lutfen listeden bir yetki seçiniz!");
                }

                if (txtYetkiAdi.Text == "")
                {
                    MessageBox.Show("Lütfen yetki adını giriniz!");
                    return;
                }

                AuthorizonUpdateVM auth = new AuthorizonUpdateVM()
                {
                    ID = (lstYetkiler.SelectedItem as AuthorizonSelectVM).ID,
                    Adi = txtYetkiAdi.Text
                };

                authorizonManager.UpdateAuthorizon(auth);
                MessageBox.Show("Yetki güncellendi");
                Yenile();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata olustu ", ex.ToString());
                throw;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                AuthorizonSelectVM secilenAuth = lstYetkiler.SelectedItem as AuthorizonSelectVM;
                AuthorizonDeleteVM auth = new AuthorizonDeleteVM()
                {
                    ID = secilenAuth.ID,
                    Adi = secilenAuth.Adi
                };

                authorizonManager.DeleteAuthorizon(auth);
                MessageBox.Show("Yetki silindi");
                Yenile();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata olustu ", ex.ToString());
                throw;
            }
        }
    }
}
