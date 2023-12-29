using GreenHouse.BLL.Logic;
using GreenHouse.VM.Category;
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
    public partial class RiskFrm : Form
    {
        Dictionary<string, List<string>> _permissions;
        RiskManager _riskManager;

        public RiskFrm()
        {
            InitializeComponent();
            _riskManager = new RiskManager();
        }

        protected List<string> permissions;
        public RiskFrm(List<string> yetkiler) : this()
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

        public RiskFrm(Dictionary<string, List<string>> permissions) : this()
        {
            _permissions = permissions;
        }

        private void RiskFrm_Load(object sender, EventArgs e)
        {
            Yenile();
            btnEkle.Tag = "Insert";
            btnSil.Tag = "Delete";
            btnGuncelle.Tag = "Update";
            buttonControl();
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtRiskAdi.Text == "")
            {
                MessageBox.Show("Lütfen bir risk adı giriniz!");
                return;
            }

            RiskInsertVM risk = new RiskInsertVM { RiskTur = txtRiskAdi.Text , AktifMi = chkAktifMi.Checked};


            _riskManager.AddRisk(risk);
            Yenile();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            RiskSelectVM risk = lstRiskler.SelectedItem as RiskSelectVM;

            if (risk == null)
            {
                MessageBox.Show("Lütfen bir risk seçiniz!");
                return;
            }
            if (txtRiskAdi.Text == "")
            {
                MessageBox.Show("Lütfen bir risk adı giriniz!");
                return;
            }

            RiskInsertVM riskInsert = new RiskInsertVM();
            riskInsert.RiskTur = txtRiskAdi.Text;
            riskInsert.AktifMi = chkAktifMi.Checked;
            riskInsert.ID = risk.ID;
            
            _riskManager.UpdateRisk(riskInsert);
            Yenile();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            RiskSelectVM risk = lstRiskler.SelectedItem as RiskSelectVM;

            if (risk == null)
            {
                MessageBox.Show("Lütfen bir risk seçiniz!");
                return;
            }

            _riskManager.DeleteRisk(risk);
            Yenile();
        }

        private void Yenile()
        {
            lstRiskler.Items.Clear();
            lstRiskler.Items.AddRange(_riskManager.GetRisk().ToArray());

        }

        private void lstRiskler_SelectedIndexChanged(object sender, EventArgs e)
        {
            RiskSelectVM risk = lstRiskler.SelectedItem as RiskSelectVM;

            if (risk == null)
            {
                return;
            }

            txtRiskAdi.Text = risk.RiskTur;
            chkAktifMi.Checked = risk.AktifMi.Value;
            
        }
    }
}
