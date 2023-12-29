using GreenHouse.BLL.Logic;
using GreenHouse.VM.Page;
using GreenHouse.VM.Risks;
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
    public partial class PageFrm : Form
    {
        PageManager _pageManager;
        public PageFrm()
        {
            InitializeComponent();
            _pageManager = new PageManager();
        }

        protected List<string> permissions;
        public PageFrm(List<string> yetkiler) : this()
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

        private void PageFrm_Load(object sender, EventArgs e)
        {
            Yenile();
            btnEkle.Tag = "Insert";
            btnSil.Tag = "Delete";
            btnGuncelle.Tag = "Update";
            buttonControl();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtSayfaAdi.Text == "")
            {
                MessageBox.Show("Lütfen sayfa adını giriniz!");
                return;
            }

            PageSelectVM page = new PageSelectVM { SayfaAdi = txtSayfaAdi.Text};

            _pageManager.AddPage(page);
            Yenile();
        }

        private void Yenile()
        {
            lstSayfalar.Items.Clear();
            lstSayfalar.Items.AddRange(_pageManager.GetPage().ToArray());

        }

        private void lstSayfalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            PageSelectVM page = lstSayfalar.SelectedItem as PageSelectVM;

            if (page == null)
            {
                return;
            }

            txtSayfaAdi.Text = page.SayfaAdi;
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            PageSelectVM page = lstSayfalar.SelectedItem as PageSelectVM;

            if (page == null)
            {
                MessageBox.Show("Lütfen bir sayfa seçiniz!");
                return;
            }

            if (txtSayfaAdi.Text == "")
            {
                MessageBox.Show("Lütfen sayfa adını giriniz!");
                return;
            }
            page.SayfaAdi = txtSayfaAdi.Text;

            _pageManager.UpdatePage(page);
            Yenile();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            PageSelectVM page = lstSayfalar.SelectedItem as PageSelectVM;

            if (page == null)
            {
                return;
            }

            _pageManager.DeletePage(page);
            Yenile();
        }


    }
}
