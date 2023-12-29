using GreenHouse.BLL.Logic;
using GreenHouse.BLL.Product;
using GreenHouse.UI.Properties;
using GreenHouse.VM.Product;
using GreenHouse.VM.User;
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
    public partial class UserProductDetailsFrm : Form
    {

        ProductSelectVM _productSelectVM;
        UserManager _userManager;
        UserDetailVM _userDetailVM;
        ProductManager _productManager;

        bool _hide = true;

        public UserProductDetailsFrm()
        {
            InitializeComponent();
            _productManager = new ProductManager();
        }

        public UserProductDetailsFrm(ProductSelectVM productSelectVM) : this()
        {
            _productSelectVM = productSelectVM;
            _userManager = new UserManager();
            _userDetailVM = Application.OpenForms["UserMainFrm"].Tag as UserDetailVM;
        }

        public UserProductDetailsFrm(ProductSelectVM productSelectVM, bool hide) : this()
        {
            _productSelectVM = productSelectVM;
            _userManager = new UserManager();
            //_userDetailVM = Application.OpenForms["UserMainFrm"].Tag as UserDetailVM;
            _hide = false;
        }

        private void UserProductDetailsFrm_Load(object sender, EventArgs e)
        {
                   lblUrunAdi.Text = _productSelectVM.UrunAdi;
            _productSelectVM.UrunFirmas.ForEach(x =>
            {
                lblUretici.Text +=  x.Firma.FirmaAdi + " ";
            });
            lblKategori.Text = _productSelectVM.Kategori.KategoriAdi;

            //_productSelectVM.Resims.ForEach(x =>
            //{
            //    ptrUrun.Image = new Bitmap(x.ResimYolu);
            //});


            if (_productSelectVM.Resims.Count == 1)
            {
                var firstImage = new Bitmap(_productSelectVM.Resims[0].ResimYolu);

                ptrUrun.Image = firstImage;
                guna2CircleButton1.Hide();
            }
            else if (_productSelectVM.Resims.Count > 1)
            {
                var firstImage = new Bitmap(_productSelectVM.Resims[0].ResimYolu);
                ptrUrun.Image = firstImage;
                guna2CircleButton1.Show();
            }


            Dictionary<string, int> list = new Dictionary<string, int>();

            List<UserListItemSelectVM> blackList=null;
            if (_hide == true)
            {
                blackList = _userManager.GetUserBlackListItems(_userDetailVM);
            }
           
            int blackListCount = 0;

            _productSelectVM.UrunIceriks.ForEach(x =>
            {
                Label lbl = new Label();
                lbl.Text = x.Bilesen.Adi;
                lbl.Font = new Font(lbl.Font, FontStyle.Bold);

                if (_hide == true)
                {
                    foreach (var blackListItem in blackList)
                    {
                        if (x.Bilesen.ID == blackListItem.IcerikID)
                        {
                            blackListCount++;
                            lbl.Text += " [K]";
                            break;
                        }
                    }
                }

                flowBilesenler.Controls.Add(lbl);
                if (x.Bilesen.RiskTur == "Yüksek" || x.Bilesen.RiskTur == "Çok Yüksek")
                {
                    lbl.ForeColor = Color.SaddleBrown;

                }
                else if (x.Bilesen.RiskTur == "Orta")
                {
                    lbl.ForeColor = Color.RosyBrown;

                }
                else if (x.Bilesen.RiskTur == "Düşük")
                {
                    lbl.ForeColor = Color.SandyBrown;

                }
                else if (x.Bilesen.RiskTur == "Risksiz")
                {
                    lbl.ForeColor = Color.Green;

                }
                else if (x.Bilesen.RiskTur == string.Empty)
                {
                    lbl.ForeColor = Color.Green;

                }

                if (!list.ContainsKey(x.Bilesen.RiskTur))
                {
                    list[x.Bilesen.RiskTur] = 0;
                }

                list[x.Bilesen.RiskTur] += 1;
            });

            if (list.ContainsKey("Çok Yüksek") && list.ContainsKey("Yüksek"))
            {
                list["Yüksek"] += list["Çok Yüksek"];
            }

            if (_productSelectVM.UrunIceriks.Count == 0)
            {
                MessageBox.Show("Üründe bileşen mevcut değildir.");
                lblBilesenlerSayisi.Text = "Bileşen mevcut değildir";
                lblRiskliSayisi.Text = "0";
                lblOrtaRiskliSayisi.Text = "0";
                lblAzRiskliSayisi.Text = "0";
                lblTemizSayisi.Text = "0";
                lblKaraListeSayisi.Text = "0";
            }
            if (list.Count >= 1)
            {
                lblRiskliSayisi.Text = list.ContainsKey("Yüksek") ? list["Yüksek"].ToString() : "0";
                lblOrtaRiskliSayisi.Text = list.ContainsKey("Orta") ? list["Orta"].ToString() : "0";
                lblAzRiskliSayisi.Text = list.ContainsKey("Düşük") ? list["Düşük"].ToString() : "0";
                lblTemizSayisi.Text = list.ContainsKey("Risksiz") ? list["Risksiz"].ToString() : "0";
                lblBilesenlerSayisi.Text = "";
            }
            lblKaraListeSayisi.Text = blackListCount.ToString();

            if (_productSelectVM.HideState)
            {
                lblUserTarafindanSaglandi.Text = "• Görüntülediğiniz ürün bilgileri " + _productSelectVM.NameAndSurname + " isimli üyemiz tarafından sağlanmıştır."; 
            }
            else
            {
                lblUserTarafindanSaglandi.Text = "• Görüntülediğiniz ürün bilgileri Anonim Kullanıcı tarafından sağlanmıştır.";
            }

            if (_hide == false)
            {
                cmbFavoriteList.Hide();
                ptrFavoriEkle.Hide();
                guna2Button1.Hide();

            }
            else
            {
                cmbFavoriteList.Show();
                ptrFavoriEkle.Show();
                guna2Button1.Show();
                cmbFavoriteList.Items.AddRange(_userManager.GetUserLists(_userDetailVM.UserRoleID).ToArray());
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if (_productSelectVM.Resims.Count >= 2)
            {
                var secondImage = new Bitmap(_productSelectVM.Resims[1].ResimYolu);
                ptrUrun.Image = secondImage;
                guna2CircleButton1.FillColor = Color.ForestGreen;
                guna2CircleButton2.FillColor = Color.White;
            }
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            if (_productSelectVM.Resims.Count >= 1)
            {
                var firstImage = new Bitmap(_productSelectVM.Resims[0].ResimYolu);
                ptrUrun.Image = firstImage;
                guna2CircleButton1.FillColor = Color.White;
                guna2CircleButton2.FillColor = Color.ForestGreen;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (cmbFavoriteList.SelectedItem != null)
            {
                if (!_productManager.IsFavorite(_productSelectVM.ID, _userDetailVM.UserRoleID, (cmbFavoriteList.SelectedItem as UserAddListInsertVM).ID))
                {
                    _userManager.AddUserFavoriteListItem(cmbFavoriteList.SelectedItem as UserAddListInsertVM, _productSelectVM.ID, _userDetailVM);
                    MessageBox.Show("Ürün favorilere eklendi");
                    ptrFavoriEkle.Image = Resources.heart_solid;
                }
                else
                {
                    MessageBox.Show("Bu ürün zaten favori listenizde mevcuttur.");
                }
            }          
        }

        private void cmbFavoriteList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_productManager.IsFavorite(_productSelectVM.ID, _userDetailVM.UserRoleID, (cmbFavoriteList.SelectedItem as UserAddListInsertVM).ID))
            {
                ptrFavoriEkle.Image = Resources.heart_solid;
            }
            else
            {
                ptrFavoriEkle.Image = Properties.Resources.heart_regular;

            }
        }
    }
}