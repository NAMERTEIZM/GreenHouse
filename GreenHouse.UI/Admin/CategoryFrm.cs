using GreenHouse.BLL.Logic;
using GreenHouse.Core;
using GreenHouse.VM.Category;
using GreenHouse.VM.Product;
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
    public partial class CategoryFrm : Form
    {
        CategoryManager _categoryManager;

        public CategoryFrm()
        {
            InitializeComponent();
            _categoryManager = new CategoryManager();
        }

        protected List<string> permissions;
        public CategoryFrm(List<string> yetkiler) : this()
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

        private void CategoryFrm_Load(object sender, EventArgs e)
        {
            btnEkle.Tag = "Insert";
            btnSil.Tag = "Delete";
            btnGuncelle.Tag = "Update";
            buttonControl();
            Yenile();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            CategoryInsertVM category = new CategoryInsertVM { KategoriAdi = txtKategoriAdi.Text };

            if (!guna2CustomCheckBox1.Checked)
            {
                if((cmbUstKategori.SelectedItem as CategorySelectVM) == null) 
                {
                    MessageBox.Show("Üst kategorisini seçmeniz gerekiyor.");
                    return; 
                }
                category.UstKategoriID = (cmbUstKategori.SelectedItem as CategorySelectVM).ID;
            }
            else
            {
                category.UstKategoriID = 1;
            }

            CategoryInsertVMValidator validator = new CategoryInsertVMValidator();
            var result = validator.Validate(category);

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

            _categoryManager.AddCategory(category);
            Yenile();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            CategorySelectVM kategori = lstKategoriler.SelectedItem as CategorySelectVM;

            if (kategori == null)
            {
                return;
            }

            kategori.KategoriAdi = txtKategoriAdi.Text;
            kategori.UstKategoriID = (cmbUstKategori.SelectedItem as CategorySelectVM).ID;

            _categoryManager.UpdateCategory(kategori);
            Yenile();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            CategorySelectVM kategori = lstKategoriler.SelectedItem as CategorySelectVM;

            if (kategori == null)
            {
                return;
            }

            _categoryManager.DeleteCategory(kategori);
            Yenile();
        }

        private void Yenile()
        {
            lstKategoriler.Items.Clear();
            cmbUstKategori.Items.Clear();
            lstKategoriler.Items.AddRange(_categoryManager.GetCategory().ToArray());
            cmbUstKategori.Items.AddRange(_categoryManager.GetCategory().ToArray());
        }

        private void guna2CustomCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CustomCheckBox1.Checked)
            {
                cmbUstKategori.Enabled = false;
            }
            else
            {
                cmbUstKategori.Enabled = true;
            }
        }

        private void lstKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategorySelectVM kategori = lstKategoriler.SelectedItem as CategorySelectVM;

            if (kategori == null)
            {
                return;
            }

            txtKategoriAdi.Text = kategori.KategoriAdi;
            cmbUstKategori.SelectedItem = kategori.UstKategori;
            cmbUstKategori.Text = kategori.UstKategori.KategoriAdi;
        }
    }
}
