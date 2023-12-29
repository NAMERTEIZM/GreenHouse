using GreenHouse.BLL.Ingredient;
using GreenHouse.VM.Ingredient;
using GreenHouse.VM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GreenHouse.VM.Risks;
using GreenHouse.BLL.Logic;
using Guna.UI2.WinForms;
using GreenHouse.VM.Product;
using GreenHouse.VM.Validation;
using FluentValidation;

namespace GreenHouse.UI.Admin
{
    public partial class Ingredient : Form
    {
        private readonly IngredientManager _ingredientManager;
        private readonly RiskManager _riskManager;


        public Ingredient()
        {
            InitializeComponent();
            _ingredientManager = new IngredientManager();
            _riskManager = new RiskManager();
        }

        protected List<string> permissions;
        public Ingredient(List<string> yetkiler) : this()
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

        private void Ingredient_Load(object sender, EventArgs e)
        {
            btnEkle.Tag = "Insert";
            btnSil.Tag = "Delete";
            btnGuncelle.Tag = "Update";
            buttonControl();
            lstBilesenler.Items.AddRange(_ingredientManager.GetIngredient().ToArray());
            //cmbRiskSeviyesi.Items.AddRange(_riskManager.GetRisk().ToArray());
            Yenile();
        }

        private void Yenile()
        {
            lstBilesenler.Items.Clear();
            cmbRiskSeviyesi.Items.Clear();
            lstBilesenler.Items.AddRange(_ingredientManager.GetIngredient().ToArray());
            cmbRiskSeviyesi.Items.AddRange(_riskManager.GetRisk().ToArray());

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if ((cmbRiskSeviyesi.SelectedItem as RiskSelectVM) == null)
                {
                    MessageBox.Show("Lütfen bir risk seviyesi seçiniz.");
                    return;
                }

                IngredientInsertVM ıngredıentInsertVM = new IngredientInsertVM()
                {
                    RiskID = (cmbRiskSeviyesi.SelectedItem as RiskSelectVM).ID,
                    Adi = txtBilesenAdi.Text,
                    Aciklama = txtAciklama.Text,
                };

                IngredientInsertVMValidator validator = new IngredientInsertVMValidator();
                var result = validator.Validate(ıngredıentInsertVM);

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

                _ingredientManager.AddIngredient(ıngredıentInsertVM);
                MessageBox.Show("Bilesen Eklendi");
                txtAciklama.Text = txtBilesenAdi.Text = string.Empty;
                Yenile();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata olustu");
                throw;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                IngredientUpdateVM ingredientUpdateVM = new IngredientUpdateVM()
                {
                    ID = (lstBilesenler.SelectedItem as IngredientSelectVM).ID,
                    RiskID = (cmbRiskSeviyesi.SelectedItem as RiskSelectVM).ID,
                    Adi = txtBilesenAdi.Text,
                    Aciklama = txtAciklama.Text,
                };

                IngredientUpdateVMValidator validator = new IngredientUpdateVMValidator();
                var result = validator.Validate(ingredientUpdateVM);

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

                _ingredientManager.UpdateIngredient(ingredientUpdateVM);
                MessageBox.Show("Bilesen Guncellendi");
                txtAciklama.Text = txtBilesenAdi.Text = string.Empty;
                Yenile();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata olustu");
                throw;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            IngredientDeleteVM bilesen = new IngredientDeleteVM();
            bilesen.ID = (lstBilesenler.SelectedItem as IngredientSelectVM).ID;
            if (_ingredientManager.DeleteIngredient(bilesen) != null)
            {
                MessageBox.Show("Bilesen Silindi");
                Yenile();
            }
            else
            {
                MessageBox.Show("Hata oluştu");
            };
        }

        private void lstBilesenler_SelectedIndexChanged(object sender, EventArgs e)
        {
            IngredientSelectVM secilen = (lstBilesenler.SelectedItem as IngredientSelectVM);
            if (secilen != null)
            {
                txtBilesenAdi.Text = secilen.Adi;
                txtAciklama.Text = secilen.Aciklama;
                cmbRiskSeviyesi.Text = secilen.RiskTur;
            }

        }
    }
}
