using GreenHouse.BLL.Logic;
using GreenHouse.Core;
using GreenHouse.VM.Company;
using GreenHouse.VM.ProductCompany;
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
    public partial class CompanyPopupFrm : Form
    {
        private readonly CompanyManager _companyManager;
        List<ProductCompanySelectVM> _firmaList = new List<ProductCompanySelectVM>();

        public CompanyPopupFrm()
        {
            InitializeComponent();
            _companyManager = new CompanyManager();
        }

        public CompanyPopupFrm(List<ProductCompanySelectVM> firmaList) : this()
        {
            _firmaList = firmaList;
        }

        private void CompanyPopupFrm_Load(object sender, EventArgs e)
        {
            Yenile();
        }

        private void Yenile()
        {
            lstUreticiler.Items.Clear();
            lstUreticiler.Items.AddRange(_companyManager.GetCompany().ToArray());
            foreach (var firma in _firmaList)
            {
                var item = lstUreticiler.Items.Cast<CompanySelectVM>().FirstOrDefault(x => x.FirmaAdi == firma.Firma.FirmaAdi);

                if (item != null)
                {
                    lstUreticiler.SetItemChecked(lstUreticiler.Items.IndexOf(item), true);
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtSirketAdi.Text == "" || txtAdres.Text == "" || txtTelefon.Text  == "")
                {
                    return;
                }

                CompanyInsertVM comp = new CompanyInsertVM()
                {
                    FirmaAdi = txtSirketAdi.Text,
                    FirmaAdresi = txtAdres.Text,
                    FirmaTel = txtTelefon.Text,
                    AktifMi = true,
                };

                _companyManager.AddCompany(comp);
                Yenile();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata olustu ", ex.ToString());
                throw;
            }
        }

        public event EventHandler<List<ProductCompanySelectVM>> DataSelectedCompany;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            List<ProductCompanySelectVM> companyData = new List<ProductCompanySelectVM>();


            lstUreticiler.CheckedItems.Cast<CompanySelectVM>().ToList().ForEach(x => 
            {
                ProductCompanySelectVM productCompany = new ProductCompanySelectVM
                {
                    Firma = x,
                    FirmaID = x.ID,
                    UrunID = x.ID
                };
                companyData.Add(productCompany);
            });

            DataSelectedCompany?.Invoke(this, companyData);

            this.Close();
        }
    }
}
