using GreenHouse.BLL.Product;
using GreenHouse.UI.User;
using GreenHouse.VM.Product;
using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace GreenHouse.UI.Admin
{
    public partial class ProductApproveFrm : Form
    {
        ProductManager _productManager;
        public ProductApproveFrm()
        {
            InitializeComponent();
            _productManager = new ProductManager();
        }

        protected List<string> permissions;
        public ProductApproveFrm(List<string> yetkiler) : this()
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

        private void ProductApproveFrm_Load(object sender, EventArgs e)
        {
            btnEkle.Tag = "Insert";
            buttonControl();
            Yenile();
            cmbFiltre.Items.Clear();
            foreach (ColumnHeader column in lwUrunler.Columns)
            {
                cmbFiltre.Items.Add(column.Text);
            }
        }

        private void Yenile()
        {
            List<ProductApproveSelectVM> products = _productManager.GetProductsApprove();
            lwUrunler.Items.Clear();

            foreach (var product in products)
            {

                ListViewItem item = new ListViewItem(product.UrunAdi);
                item.SubItems.Add(product.BarkodNumarasi);
                item.SubItems.Add(product.OnayDurumu.HasValue ? (product.OnayDurumu.Value ? "Onaylandı" : "Beklemede") : "Bilinmiyor");
                item.SubItems.Add(product.Adi + " " + product.Soyadi);
                item.SubItems.Add(product.OlusturulmaTarihi.ToString());
                // subitem.Tag = product.OlusturulmaTarihi;
                item.Tag = product;

                if (product.OnayDurumu.HasValue && product.OnayDurumu.Value)
                {
                    item.ForeColor = Color.Green;
                }
                else
                {
                    item.ForeColor = Color.Red;
                }
                lwUrunler.Items.Add(item);
            }


        }





        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (lwUrunler.SelectedItems.Count == 1)
            {
                ListViewItem item = lwUrunler.SelectedItems[0];
                if (item.SubItems[2].Text == "Beklemede")
                {
                    if (_productManager.UpdateProductApproveStatus((item.Tag as ProductApproveSelectVM).ProductID))
                    {
                        MessageBox.Show("Ürün başarıyla onaylandı");
                        Yenile();
                        return;
                    }
                    MessageBox.Show("Bir hata oluştu");
                }
            }
        }

        private void lwUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAramaMetni_TextChanged(object sender, EventArgs e)
        {
            Yenile();

            if (cmbFiltre.SelectedItem == null) { return; }
            string seciliKolon = cmbFiltre.SelectedItem.ToString();
            string aranaKelime = txtAramaMetni.Text.ToLower();

            List<ListViewItem> eslesenler = new List<ListViewItem>();

            foreach (ListViewItem item in lwUrunler.Items)
            {
                if (item.SubItems.Count > 0)
                {
                    string columnText = item.SubItems[cmbFiltre.SelectedIndex].Text.ToLower();

                    if (columnText.Contains(aranaKelime))
                    {
                        eslesenler.Add(item);
                    }
                }
            }

            lwUrunler.Items.Clear();

            foreach (ListViewItem item in eslesenler)
            {
                lwUrunler.Items.Add(item);
            }
        }


        private void formgetir(Form frm)
        {
            frm.MdiParent = Application.OpenForms["MainPage"];
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        private void lwUrunler_DoubleClick(object sender, EventArgs e)
        {
            if (lwUrunler.SelectedItems.Count == 1)
            {
                ListViewItem selectedItem = lwUrunler.SelectedItems[0];
                ProductApproveSelectVM productSelectVM = selectedItem.Tag as ProductApproveSelectVM;
                ProductSelectVM product = _productManager.GetProductDetail(productSelectVM.ProductID);
                

                UserProductDetailsFrm productDetails = new UserProductDetailsFrm(product, false);
                if (Application.OpenForms["productDetails"] == null)
                {
                    formgetir(productDetails);
                }
            }
        }
    }
}