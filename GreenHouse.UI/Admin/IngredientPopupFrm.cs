using GreenHouse.BLL.Ingredient;
using GreenHouse.BLL.Logic;
using GreenHouse.VM;
using GreenHouse.VM.Company;
using GreenHouse.VM.Ingredient;
using GreenHouse.VM.ProductCompany;
using GreenHouse.VM.ProductIngredient;
using GreenHouse.VM.Risks;
using GreenHouse.VM.Validation;
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
    public partial class IngredientPopupFrm : Form
    {
        private readonly IngredientManager _ingredientManager;
        private readonly RiskManager _riskManager;
        
        List<ProductIngredientSelectVM> _ingredientList = new List<ProductIngredientSelectVM>();

        public IngredientPopupFrm()
        {
            InitializeComponent();
            _ingredientManager = new IngredientManager();
            _riskManager = new RiskManager();
        }

        public IngredientPopupFrm(List<ProductIngredientSelectVM> ingredientList) : this()
        {
            _ingredientList = ingredientList;
        }

        private void IngredientPopupFrm_Load(object sender, EventArgs e)
        {
            Yenile();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBilesenAdi.Text == "" || txtAciklama.Text == "")
                {
                    return;
                }

                IngredientInsertVM ıngredıentInsertVM = new IngredientInsertVM()
                {
                    RiskID = (cmbRiskTuru.SelectedItem as RiskSelectVM).ID,
                    Adi = txtBilesenAdi.Text,
                    Aciklama = txtAciklama.Text,
                };

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

        public event EventHandler<List<ProductIngredientSelectVM>> DataSelected;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            List<ProductIngredientSelectVM> companyData = new List<ProductIngredientSelectVM>();


            lstBilesenler.CheckedItems.Cast<IngredientSelectVM>().ToList().ForEach(x =>
            {
                ProductIngredientSelectVM productIngredient = new ProductIngredientSelectVM
                {
                    Bilesen = x,
                    UrunID = x.ID,
                    BilesenID = x.ID
                };
                companyData.Add(productIngredient);
            });

            DataSelected?.Invoke(this, companyData);

            this.Close();
        }

        private void Yenile()
        {
            cmbRiskTuru.Items.AddRange(_riskManager.GetRisk().ToArray());
            lstBilesenler.Items.Clear();
            lstBilesenler.Items.AddRange(_ingredientManager.GetIngredient().ToArray());
            foreach (var bilesen in _ingredientList)
            {
                var item = lstBilesenler.Items.Cast<IngredientSelectVM>().FirstOrDefault(x => x.Adi == bilesen.Bilesen.Adi);

                if (item != null)
                {
                    lstBilesenler.SetItemChecked(lstBilesenler.Items.IndexOf(item), true);
                }
            }
        }
    }
}
