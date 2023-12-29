using GreenHouse.BLL.Logic;
using GreenHouse.BLL.Product;
using GreenHouse.VM.Category;
using GreenHouse.VM.Company;
using GreenHouse.VM.Picture;
using GreenHouse.VM.Product;
using GreenHouse.VM.ProductCompany;
using GreenHouse.VM.ProductIngredient;
using GreenHouse.VM.Validation;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenHouse.UI.Admin
{
    public partial class ProductFrm : Form
    {
        private readonly ProductManager _productManager;
        private readonly CategoryManager _categoryManager;

        private List<ProductSelectVM> products;
        private List<CategorySelectVM> categories;

        List<ProductCompanySelectVM> selectedCompanies; 

        public ProductFrm()
        {
            InitializeComponent();
            _productManager = new ProductManager();
            _categoryManager = new CategoryManager();
            selectedCompanies = new List<ProductCompanySelectVM>();
        }

        protected List<string> permissions;
        public ProductFrm(List<string> yetkiler) : this()
        {
            permissions = yetkiler;

        }

        private void Product_Load(object sender, EventArgs e)
        {
            btnEkle.Tag = "Insert";
            btnSil.Tag = "Delete";
            btnGuncelle.Tag = "Update";
            buttonControl();
            categories = _categoryManager.GetCategory();
            cmbKategori.Items.AddRange(categories.ToArray());
            Yenile();
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

        private void Yenile()
        {
            products = _productManager.GetProducts();
            lstUrunler.Items.Clear();
            lstUrunler.Items.AddRange(products.ToArray());          
        }

        List<Guna2Chip> guna2Chips = new List<Guna2Chip>();

        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductSelectVM product = lstUrunler.SelectedItem as ProductSelectVM;
            if (product != null)
            {
                txtUrunAdi.Text = product.UrunAdi;
                txtAciklama.Text = product.UrunAciklamasi;
                txtBarkod.Text = product.BarkodNumarasi;
                cmbKategori.Text = (product.Kategori as CategorySelectVM).KategoriAdi;

                var urunicerikleri = product.UrunIceriks.ToList();
                var ureticiler = product.UrunFirmas.ToList();              
                
                if (guna2Chips.Count != 0)
                {
                    guna2Chips.ForEach(x =>
                    {
                        flowBilesenler.Controls.Remove(x);
                        x.Dispose();
                    });
                }
                urunicerikleri.ForEach(x =>
                {                    
                    Guna2Chip guna2Chip = new Guna2Chip();
                    guna2Chip.Text = x.Bilesen.Adi;
                    ChipRenkAyarla(guna2Chip, x.Bilesen.RiskTur);
                    AyarlaChipGenislik(guna2Chip);
                    guna2Chip.Height = 30;
                    guna2Chip.Tag = x;
                    flowBilesenler.Controls.Add(guna2Chip);
                    guna2Chips.Add(guna2Chip);
                });

                //
                string tumFirmalar = "";
                lblUreticiler.Tag = product.UrunFirmas.ToList();
                ureticiler.ForEach(x =>
                {
                    tumFirmalar += (tumFirmalar==""?"":", ") + x.Firma.FirmaAdi;
                });
                tumFirmalar = (tumFirmalar == "" ? "Üreticisi Yok" : tumFirmalar);
                lblUreticiler.Text = tumFirmalar;

                flowResimler.Controls.Clear();
                var urunResimleri = product.Resims.ToList();
                foreach (var resim in urunResimleri)
                {
                    PictureBox pictureBox = new PictureBox();
                    if (File.Exists(resim.ResimYolu)) 
                    {
                        pictureBox.Image = Image.FromFile(resim.ResimYolu);
                    }
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Width = 50;
                    pictureBox.Height = 50;
                    flowResimler.Controls.Add(pictureBox);
                }
            }

        }

        private void ChipRenkAyarla(Guna2Chip chip, string riskTur)
        {
            if (riskTur == "Çok Yüksek")
            {
                chip.FillColor = Color.DarkRed;
            }
            else if (riskTur == "Yüksek")
            {
                chip.FillColor = Color.Red;
            }
            else if (riskTur == "Orta")
            {
                chip.FillColor = Color.OrangeRed;
            }
            else if (riskTur == "Düşük")
            {
                chip.FillColor = Color.Orange;
            }
            else if (riskTur == "Risksiz")
            {
                chip.FillColor = Color.Green;
            }         
        }

        private void AyarlaChipGenislik(Guna2Chip chip)
        {
            int icerikUzunlugu = TextRenderer.MeasureText(chip.Text, chip.Font).Width;

            icerikUzunlugu += 25;

            chip.Width = icerikUzunlugu;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            List<ProductIngredientSelectVM> productIngredientSelectVMs = new List<ProductIngredientSelectVM>();



            foreach (Guna2Chip control in flowBilesenler.Controls)
            {
                productIngredientSelectVMs.Add(control.Tag as ProductIngredientSelectVM);
            }

            using (var popupForm = new IngredientPopupFrm(productIngredientSelectVMs))
            {
                popupForm.DataSelected += (s, selectedData) =>
                {

                    if (guna2Chips.Count != 0)
                    {
                        guna2Chips.ForEach(x =>
                        {
                            flowBilesenler.Controls.Remove(x);
                            x.Dispose();
                        });
                    }

                    selectedData.ForEach(x =>
                    {
                        Guna2Chip guna2Chip = new Guna2Chip();
                        guna2Chip.Text = x.Bilesen.Adi;
                        ChipRenkAyarla(guna2Chip, x.Bilesen.RiskTur);
                        AyarlaChipGenislik(guna2Chip);
                        guna2Chip.Height = 30;
                        guna2Chip.Tag = x;
                        flowBilesenler.Controls.Add(guna2Chip);
                        guna2Chips.Add(guna2Chip);
                    });

                };
                popupForm.ShowDialog();
            }



        }

        private void btnUreticiEkle_Click(object sender, EventArgs e)
        {
            List<ProductCompanySelectVM> existingFirmaList = lblUreticiler.Tag as List<ProductCompanySelectVM>;

            if (existingFirmaList == null)
            {
                existingFirmaList = new List<ProductCompanySelectVM>();
            }

            using (var popupForm = new CompanyPopupFrm(selectedCompanies))
            {
                popupForm.DataSelectedCompany += (s, selectedData) =>
                {

                    lblUreticiler.Tag = selectedData;
                    string tumFirmalar = "";
                    selectedData.ForEach(x =>
                    {
                        tumFirmalar += (tumFirmalar == "" ? "" : ", ") + x.Firma.FirmaAdi;
                    });
                    tumFirmalar = (tumFirmalar == "" ? "Üreticisi Yok" : tumFirmalar);
                    lblUreticiler.Text = tumFirmalar;

                    selectedCompanies = selectedData;
                };
                popupForm.ShowDialog();
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] selectedImagePaths = openFileDialog1.FileNames;

                if (selectedImagePaths.Length == 2)
                {
                    foreach (string imagePath in selectedImagePaths)
                    {
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Size = new Size(55, 45); 
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom; 
                        pictureBox.Image = Image.FromFile(imagePath);
                        

                        PictureSelectVM resim = new PictureSelectVM { ResimYolu = imagePath };
                        pictureBox.Tag = resim;

                        flowResimler.Controls.Add(pictureBox);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen 2 adet resim seçin.");
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                ProductInsertVM productInsertVM = new ProductInsertVM();

                productInsertVM.UrunAdi = txtUrunAdi.Text;
                productInsertVM.UrunAciklamasi = txtAciklama.Text;
                productInsertVM.BarkodNumarasi = txtBarkod.Text;
                productInsertVM.UrunKategori = cmbKategori.SelectedItem as CategorySelectVM;

                foreach (PictureBox control in flowResimler.Controls)
                {
                    productInsertVM.Resims.Add(control.Tag as PictureSelectVM);
                }

                foreach (Guna2Chip control in flowBilesenler.Controls)
                {
                    productInsertVM.UrunIceriks.Add(control.Tag as ProductIngredientSelectVM);
                }

                foreach (Label control in flowUreticiler.Controls)
                {
                    productInsertVM.UrunFirmas = control.Tag as List<ProductCompanySelectVM>;
                }

                ProductInsertVMValidator validator = new ProductInsertVMValidator();
                var result = validator.Validate(productInsertVM);

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

                _productManager.AddProducts(productInsertVM);
                MessageBox.Show("Ürün Eklendi");
                Yenile();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu");
                throw;
            }


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                ProductInsertVM productInsertVM = new ProductInsertVM();

                productInsertVM.ID = (lstUrunler.SelectedItem as ProductSelectVM).ID;
                productInsertVM.UrunAdi = txtUrunAdi.Text;
                productInsertVM.UrunAciklamasi = txtAciklama.Text;
                productInsertVM.BarkodNumarasi = txtBarkod.Text;
                productInsertVM.UrunKategori = cmbKategori.SelectedItem as CategorySelectVM;

                foreach (PictureBox control in flowResimler.Controls)
                {
                    productInsertVM.Resims.Add(control.Tag as PictureSelectVM);
                }

                if (productInsertVM.Resims.Count != 2)
                {
                    MessageBox.Show("2 adet resim seçmelisiniz.");
                    return;
                }

                foreach (Guna2Chip control in flowBilesenler.Controls)
                {
                    productInsertVM.UrunIceriks.Add(control.Tag as ProductIngredientSelectVM);
                }

                foreach (Label control in flowUreticiler.Controls)
                {
                    productInsertVM.UrunFirmas = control.Tag as List<ProductCompanySelectVM>;
                }

                ProductInsertVMValidator validator = new ProductInsertVMValidator();
                var result = validator.Validate(productInsertVM);

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

                _productManager.UpdateProduct(productInsertVM);
                MessageBox.Show("Ürün Güncellendi");
                Yenile();
            }
            catch (Exception ex)
            {

                throw;
            }

            

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                ProductInsertVM productInsertVM = new ProductInsertVM();

                productInsertVM.ID = (lstUrunler.SelectedItem as ProductSelectVM).ID;
                productInsertVM.UrunAdi = txtUrunAdi.Text;
                productInsertVM.UrunAciklamasi = txtAciklama.Text;
                productInsertVM.BarkodNumarasi = txtBarkod.Text;
                productInsertVM.UrunKategori = cmbKategori.SelectedItem as CategorySelectVM;

                ProductInsertVMValidator validator = new ProductInsertVMValidator();
                var result = validator.Validate(productInsertVM);

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

                foreach (PictureBox control in flowResimler.Controls)
                {
                    productInsertVM.Resims.Add(control.Tag as PictureSelectVM);
                }

                foreach (Guna2Chip control in flowBilesenler.Controls)
                {
                    productInsertVM.UrunIceriks.Add(control.Tag as ProductIngredientSelectVM);
                }

                foreach (Label control in flowUreticiler.Controls)
                {
                    productInsertVM.UrunFirmas = control.Tag as List<ProductCompanySelectVM>;
                }

                _productManager.DeleteProduct(productInsertVM);
                MessageBox.Show("Ürün Silindi");
                Yenile();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
