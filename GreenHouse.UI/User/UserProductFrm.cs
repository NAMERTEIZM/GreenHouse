using GreenHouse.BLL.Logic;
using GreenHouse.BLL.Product;
using GreenHouse.UI.Admin;
using GreenHouse.VM.Category;
using GreenHouse.VM.Picture;
using GreenHouse.VM.Product;
using GreenHouse.VM.ProductCompany;
using GreenHouse.VM.ProductIngredient;
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

namespace GreenHouse.UI.User
{
    public partial class UserProductFrm : Form
    {
        List<ProductCompanySelectVM> selectedCompanies; 

        public UserProductFrm()
        {
            InitializeComponent();
            selectedCompanies = new List<ProductCompanySelectVM>();
        }

        ProductManager _productManager;
        CategoryManager _categoryManager;
        List<CategorySelectVM> _categories;
        UserDetailVM _userDetailVM;
        private void UserProductFrm_Load(object sender, EventArgs e)
        {
            _productManager = new ProductManager();
            _categoryManager = new CategoryManager();
            _categories = _categoryManager.GetCategory();
            cmbKategori.Items.AddRange(_categories.ToArray());
            _userDetailVM =  Application.OpenForms["UserMainFrm"].Tag as UserDetailVM;
        }
        private void Yenile()
        {
            txtAciklama.Text = txtBarkod.Text = txtUrunAdi.Text = string.Empty;
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            try
            {
                ProductUserInsertVM productUserInsertVM = new ProductUserInsertVM();

                productUserInsertVM.UrunAdi = txtUrunAdi.Text;
                productUserInsertVM.UrunAciklamasi = txtAciklama.Text;
                productUserInsertVM.BarkodNumarasi = txtBarkod.Text;
                productUserInsertVM.UrunKategori = cmbKategori.SelectedItem as CategorySelectVM;
                productUserInsertVM.KullaniciGozukmeDurumu = chkGozukmeDurumu.Checked;

                foreach (PictureBox control in flowResimler.Controls)
                {
                    productUserInsertVM.Resims.Add(control.Tag as PictureSelectVM);
                }

                foreach (Guna2Chip control in flowBilesenler.Controls)
                {
                    productUserInsertVM.UrunIceriks.Add(control.Tag as ProductIngredientSelectVM);
                }

                foreach (Label control in flowUreticiler.Controls)
                {
                    productUserInsertVM.UrunFirmas = control.Tag as List<ProductCompanySelectVM>;
                }

                ProductUserInsertVMValidator validator = new ProductUserInsertVMValidator();
                var result = validator.Validate(productUserInsertVM);

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

                _productManager.AddProductsUser(productUserInsertVM,_userDetailVM);
                MessageBox.Show("Ürün Onaya Gönderildi");
                Yenile();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu");
                throw;
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

        List<Guna2Chip> guna2Chips = new List<Guna2Chip>();

        private void btnBilesenEkle_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Lütfen 2 adet resim seçiniz.");
                }
            }
        }
    }
}