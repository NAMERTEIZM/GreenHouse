using GreenHouse.BLL.Admin;
using GreenHouse.UI.User;
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

namespace GreenHouse.UI.Admin
{
    public partial class MainPage : Form
    {
        Dictionary<string, List<string>> _permissions;

        public MainPage()
        {
            InitializeComponent();
        }

        public MainPage(Dictionary<string, List<string>> permissions) : this()
        {
            _permissions = permissions;
            this.Tag = permissions;
        }

        public List<string> HangiYetkilereSahip(string sayfa, Dictionary<string, List<string>> yetkiler)
        {
            List<string> anahtarlar = new List<string>();

            foreach (var kvp in yetkiler)
            {
                if (kvp.Value.Contains(sayfa))
                {
                    anahtarlar.Add(kvp.Key);
                }
            }

            return anahtarlar;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            foreach (ToolStripItem item in menuStrip1.Items)
            {
                if (item is ToolStripMenuItem)
                {
                    ToolStripMenuItem menuItem = (ToolStripMenuItem)item;
                    string itemName = menuItem.Text;

                    foreach (var yetki in _permissions)
                    {
                        if (yetki.Key == "Select" && yetki.Value.Contains(itemName))
                        {
                            menuItem.Enabled = true;
                            break;
                        }
                        else
                        {
                            menuItem.Enabled = false;
                        }
                    }
                }
            }
        }

        private void formgetir(Form frm)
        {
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        private void userFrmToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            UserFrm kullaniciekle = new UserFrm(HangiYetkilereSahip("Kullanıcılar", _permissions));
            if (Application.OpenForms["kullaniciekle"] == null)
            {
                formgetir(kullaniciekle);
            }
        }

        private void productFrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductFrm urunekle = new ProductFrm(HangiYetkilereSahip("Ürünler", _permissions));
            if (Application.OpenForms["urunekle"] == null)
            {
                formgetir(urunekle);
            }
        }

        private void categoryFrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryFrm kategoriekle = new CategoryFrm(HangiYetkilereSahip("Kategoriler", _permissions));
            if (Application.OpenForms["kategoriekle"] == null)
            {
                formgetir(kategoriekle);
            }
        }
        private void ingredientFrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ingredient bilesenekle = new Ingredient(HangiYetkilereSahip("Bileşenler", _permissions));
            if (Application.OpenForms["bilesenekle"] == null)
            {
                formgetir(bilesenekle);
            }
        }

        private void riskFrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RiskFrm riskekle = new RiskFrm(HangiYetkilereSahip("Riskler", _permissions));
            if (Application.OpenForms["riskekle"] == null)
            {
                formgetir(riskekle);
            }
        }

        private void companyFrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyFrm ureticiekle = new CompanyFrm(HangiYetkilereSahip("Üreticiler", _permissions));
            if (Application.OpenForms["ureticiekle"] == null)
            {
                formgetir(ureticiekle);
            }
        }

        private void rollerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RolFrm rolekle = new RolFrm(HangiYetkilereSahip("Roller", _permissions));
            if (Application.OpenForms["rolekle"] == null)
            {
                formgetir(rolekle);
            }
        }

        private void sayfalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageFrm sayfaekle = new PageFrm(HangiYetkilereSahip("Sayfalar", _permissions));
            if (Application.OpenForms["sayfaekle"] == null)
            {
                formgetir(sayfaekle);
            }
        }
        private void yetkilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorizationFrm yetkiekle = new AuthorizationFrm(HangiYetkilereSahip("Yetkiler", _permissions));
            if (Application.OpenForms["yetkiekle"] == null)
            {
                formgetir(yetkiekle);
            }
        }

        private void urunOnayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductApproveFrm urunonayekle = new ProductApproveFrm(HangiYetkilereSahip("Ürün Onay", _permissions));
            if (Application.OpenForms["urunonayekle"] == null)
            {
                formgetir(urunonayekle);
            }
        }

        private void yetkiAtaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYetkiRol yetkiAta = new FormYetkiRol(HangiYetkilereSahip("Yetki Ata", _permissions));
            if (Application.OpenForms["yetkiAta"] == null)
            {
                formgetir(yetkiAta);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login lp = new Login();
            lp.Show();
            this.Close();
        }
    }
}

