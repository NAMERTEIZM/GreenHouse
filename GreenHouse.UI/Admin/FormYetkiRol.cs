using GreenHouse.BLL.Logic;
using GreenHouse.BLL.Product;
using GreenHouse.Core;
using GreenHouse.VM.Authorizon;
using GreenHouse.VM.Page;
using GreenHouse.VM.Product;
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
	public partial class FormYetkiRol : Form
	{
		private readonly RoleManager _rolemanager;
		private readonly PageManager _pagemanager;
		private readonly AuthorizonManager _authorizonmanager;
		public FormYetkiRol()
		{
			InitializeComponent();
			_rolemanager = new RoleManager();
			_pagemanager = new PageManager();	
			_authorizonmanager = new AuthorizonManager();
		}

        protected List<string> permissions;
        public FormYetkiRol(List<string> yetkiler) : this()
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

        private void FormYetkiRol_Load(object sender, EventArgs e)
		{
            btnEkle.Tag = "Insert";
            btnSil.Tag = "Delete";
            buttonControl();
            Doldur();
			ListeYenile();
        }

        public void Doldur()
        {
            cmbSayfa.Items.AddRange(_pagemanager.GetPage().ToArray());
            cmbRol.Items.AddRange(_rolemanager.GetRole().ToArray());
            cmbYetki.Items.AddRange(_authorizonmanager.GetAuthorizon().ToArray());

        }

        public void ListeYenile()
		{
            List<PageAuthorizationVM> roles = _rolemanager.GetRoleWithAll();
            lstSayfaYetki.Items.Clear();

            foreach (var role in roles)
            {

                ListViewItem item = new ListViewItem(role.Role.RolAdi);
                item.SubItems.Add(role.Page.SayfaAdi);
                item.SubItems.Add(role.Authorizon.Adi);


                item.Tag = role;

                lstSayfaYetki.Items.Add(item);
            }
        }

		private void btnEkle_Click(object sender, EventArgs e)
		{
            RoleSelectVM roleSelect = cmbRol.SelectedItem as RoleSelectVM;
            PageSelectVM pageSelect = cmbSayfa.SelectedItem as PageSelectVM;
            AuthorizonSelectVM authorizonSelect = cmbYetki.SelectedItem as AuthorizonSelectVM;

            if(roleSelect==null ||pageSelect==null || authorizonSelect == null)
            {
                MessageBox.Show("Lütfen rol,yetki ve sayfa seçiniz.");
                return;
            }

            int selectedRolID = (roleSelect).ID;
			int selectedPageID=(pageSelect).ID;
			int selectedAuthorizon = (authorizonSelect).ID;

			if (_rolemanager.ChangePageAuthorizon(new PageAuthorizationInsertVM
            {
				RolID = selectedRolID,
				SayfaID = selectedPageID,
				YetkiID = selectedAuthorizon,
			}))
			{
                MessageBox.Show("Atama yapildi");
				ListeYenile();
            }							
			else
			{
				MessageBox.Show("HATA ! : Aynı kayıttan veritabanında var");
			}
			
		}

        private void btnSil_Click(object sender, EventArgs e)
        {
			if(lstSayfaYetki.SelectedItems.Count == 1)
			{
                PageAuthorizationVM sayfaYetki = lstSayfaYetki.SelectedItems[0].Tag as PageAuthorizationVM;

				if (sayfaYetki != null)
				{
                    _rolemanager.DeletePageAuthorizon(new PageAuthorizationInsertVM { ID = sayfaYetki.ID });
					MessageBox.Show("Kayıt silindi");
                    ListeYenile();
                }
            }
        }
    }
}
