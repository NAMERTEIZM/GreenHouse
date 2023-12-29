using FluentValidation;
using GreenHouse.BLL.Logic;
using GreenHouse.VM.Company;
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
    public partial class CompanyFrm : Form
    {
		CompanyManager companyManager;

		public CompanyFrm()
        {
            InitializeComponent();
			companyManager = new CompanyManager();
		}
       
		protected List<string> permissions;
		public CompanyFrm(List<string> yetkiler) : this()
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
		private void CompanyFrm_Load(object sender, EventArgs e)
		{
			btnEkle.Tag = "Insert";
			btnSil.Tag = "Delete";
			btnGuncelle.Tag = "Update";
			buttonControl();
			Yenile();
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			try
			{
				CompanyInsertVM comp = new CompanyInsertVM()
				{
					FirmaAdi = txtUreticiAdi.Text,
					FirmaAdresi = txtAdres.Text,
					FirmaTel = txtTelefonNumarasi.Text,
					AktifMi = chkAktifMi.Checked,
				};

                CompanyInsertVMValidator validator = new CompanyInsertVMValidator();
                var result = validator.Validate(comp);

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


                companyManager.AddCompany(comp);
				MessageBox.Show("Firma eklendi");
				Yenile();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata olustu ",ex.ToString());
				throw;
			}
			
		}

		private void Yenile()
		{
			lstUreticiler.Items.Clear();
			lstUreticiler.Items.AddRange(companyManager.GetCompany().ToArray());
		}

		private void lstUreticiler_SelectedIndexChanged(object sender, EventArgs e)
		{
			CompanySelectVM ClickedCompany = new CompanySelectVM();
			ClickedCompany=lstUreticiler.SelectedItem as CompanySelectVM ;
			if (ClickedCompany != null)
			{
                txtUreticiAdi.Text = ClickedCompany.FirmaAdi;
                txtAdres.Text = ClickedCompany.FirmaAdresi;
                txtTelefonNumarasi.Text = ClickedCompany.FirmaTel;
                if (ClickedCompany != null && ClickedCompany.AktifMi.HasValue)
                {
                    // CheckBox'ın durumunu, AktifMi özelliğinin değerine göre ayarla
                    chkAktifMi.Checked = ClickedCompany.AktifMi.Value;
                }
            }
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			try
			{
				CompanyUpdateVM comp = new CompanyUpdateVM()
				{
					ID = (lstUreticiler.SelectedItem as CompanySelectVM).ID,
					FirmaAdi = txtUreticiAdi.Text,
					FirmaAdresi = txtAdres.Text,
					FirmaTel = txtTelefonNumarasi.Text,
					AktifMi = chkAktifMi.Checked,
				};

                CompanyUpdateVMValidator validator = new CompanyUpdateVMValidator();
                var result = validator.Validate(comp);

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

                companyManager.UpdateCompany(comp);
				MessageBox.Show("Firma guncellendi");
				Yenile();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata olustu ", ex.ToString());
				throw;
			}
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			try
			{
				CompanySelectVM secilenCompany = lstUreticiler.SelectedItem as CompanySelectVM;
				CompanyDeleteVM comp = new CompanyDeleteVM()
				{
					ID = secilenCompany.ID,
					FirmaAdi = secilenCompany.FirmaAdi,
					FirmaAdresi = secilenCompany.FirmaAdresi,
					FirmaTel = secilenCompany.FirmaTel,
					AktifMi = secilenCompany.AktifMi,
				};

				companyManager.DeleteCompany(comp);
				MessageBox.Show("Firma silindi");
				Yenile();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata olustu ", ex.ToString());
				throw;
			}
		}
	}
}
