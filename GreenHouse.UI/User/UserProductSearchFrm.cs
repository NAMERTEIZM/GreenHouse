using GreenHouse.BLL.Logic;
using GreenHouse.BLL.Product;
using GreenHouse.VM.Category;
using GreenHouse.VM.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GreenHouse.UI.User
{
    public partial class UserProductSearchFrm : Form
    {
        private readonly ProductManager _productManager;
        private readonly CategoryManager _categoryManager;
        private List<CategorySelectVM> _categories;
        public UserProductSearchFrm()
        {
            InitializeComponent();
            _productManager = new ProductManager();
            _categoryManager = new CategoryManager();
            LWFill();

            LoadCategories();
            cmbKategori.SelectedIndex = 0;
        }
        private void LWFill()
        {
            var products = _productManager.GetProducts();
            foreach (var product in products)
            {
                ListViewItem item = new ListViewItem(product.UrunAdi);
                item.SubItems.Add(product.BarkodNumarasi);
                item.SubItems.Add(product.Kategori.KategoriAdi);

                item.Tag = product;
                lwUrunler.Items.Add(item);
            }
        }
        private void LoadCategories()
        {
            _categories = _categoryManager.GetCategory();
            _categories.Insert(0, new CategorySelectVM { ID = 0, KategoriAdi = "Tüm Kategoriler" });
            cmbKategori.DataSource = _categories;
            cmbKategori.DisplayMember = "KategoriAdi";
            cmbKategori.ValueMember = "ID";
        }

        private void txtUrunAra_TextChanged(object sender, EventArgs e)
        {
            List<ProductSelectVM> products = _productManager.GetProductsFilter(txtUrunAra.Text, (int)cmbKategori.SelectedValue);

            lwUrunler.Items.Clear();

            foreach (var product in products)
            {
                ListViewItem item = new ListViewItem(product.UrunAdi);
                item.SubItems.Add(product.BarkodNumarasi);
                item.SubItems.Add(product.Kategori.KategoriAdi);
                item.SubItems.Add(product.UrunFirmas.ToString());
                item.Tag = product;
                lwUrunler.Items.Add(item);
            }

        }

        private void formgetir(Form frm)
        {
            frm.MdiParent = Application.OpenForms["UserMainFrm"];
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        private void lwUrunler_DoubleClick(object sender, EventArgs e)
        {
            if (lwUrunler.SelectedItems.Count == 1)
            {
                ListViewItem selectedItem = lwUrunler.SelectedItems[0];
                ProductSelectVM productSelectVM = selectedItem.Tag as ProductSelectVM;

                UserProductDetailsFrm productDetails = new UserProductDetailsFrm(productSelectVM);
                if (Application.OpenForms["productDetails"] == null)
                {
                    formgetir(productDetails);
                }
            }
        }



        private void lwUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<ProductSelectVM> products = _productManager.GetProductsFilter(txtUrunAra.Text, (int)cmbKategori.SelectedIndex);

            lwUrunler.Items.Clear();

            foreach (var product in products)
            {
                ListViewItem item = new ListViewItem(product.UrunAdi);
                item.SubItems.Add(product.BarkodNumarasi);
                item.SubItems.Add(product.Kategori.KategoriAdi);
                item.SubItems.Add(product.UrunFirmas.ToString());
                item.Tag = product;
                lwUrunler.Items.Add(item);
            }
        }

        //Kategori filtresi

    }
}
