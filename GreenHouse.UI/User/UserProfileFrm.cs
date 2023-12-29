using GreenHouse.BLL.Ingredient;
using GreenHouse.BLL.Logic;
using GreenHouse.BLL.Product;
using GreenHouse.VM;
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
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace GreenHouse.UI.User
{
    public partial class UserProfileFrm : Form
    {
        
        private readonly UserManager _userManager;
        private readonly ProductManager _productManager;      
        private readonly IngredientManager _ingredientManager;

        private UserDetailVM _userDetailVM;

        public UserProfileFrm()
        {
            InitializeComponent();
            _userManager = new UserManager();
            _productManager = new ProductManager();
            _ingredientManager = new IngredientManager();
        }
        int userPoint;
        private void UserProfileFrm_Load(object sender, EventArgs e)
        {
            UserMainFrm f2 = null;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "UserMainFrm")
                {
                    f2 = (UserMainFrm)f;
                    _userDetailVM = f2.Tag as UserDetailVM;
                    break;
                }
            }

            lblAdSoyad.Text = _userDetailVM.Adi + " " + _userDetailVM.Soyadi;
            lblUyelikTarihi.Text = _userDetailVM.OlusturulmaTarihi.ToString();

            EkledigimUrunleriGetir();

            cmbListelerim.Items.AddRange(_userManager.GetUserLists(_userDetailVM.UserRoleID).ToArray());

            userPoint = _userManager.GetUserPoint(_userDetailVM.UserRoleID);
            pbarPremium.Minimum = 0;
            pbarPremium.Maximum = 25;
            lblPuanToplamalisin.Text = $"Uyelik icin {25 - userPoint} puan toplamalısınız";
            pbarPremium.Value = userPoint;

            foreach (ColumnHeader column in lwEkledigimUrunler.Columns)
            {
                cmbFiltre.Items.Add(column.Text);
            }

            listBox1.Items.AddRange(_ingredientManager.GetIngredientWithoutUserBlackListItems(_userDetailVM).ToArray());

            KaraListeYenile();
        }

        private void btnSifreGuncelle_Click(object sender, EventArgs e)
        {

            UserInsertVM userInsertVM = new UserInsertVM();


            userInsertVM.ID = _userDetailVM.ID;
            userInsertVM.PasswordHash = _userDetailVM.PasswordHash;
            string willUpdatePass = txtYeniSifre.Text;

            if (txtEskiSifre.Text == userInsertVM.PasswordHash && txtYeniSifre.Text == txtYeniSifreTekrar.Text)
            {
                _userManager.UpdatePassword(userInsertVM, willUpdatePass);
                MessageBox.Show("Şifreniz Başarıyla Güncellenmiştir.");
                Yenile();
                return;

            }
            MessageBox.Show("Şifre Güncellenirken Hata Oluştu.");

        }
        private void Yenile()
        {
            txtEskiSifre.Text = string.Empty;
            txtYeniSifre.Text = string.Empty;
            txtYeniSifreTekrar.Text = string.Empty;
            EkledigimUrunleriGetir();

        }

        private void btnEpostaGuncelle_Click_1(object sender, EventArgs e)
        {
            UserInsertVM uivm = new UserInsertVM();

            uivm.ID = _userDetailVM.ID;
            uivm.Email = _userDetailVM.Email;
            string willUpdateemail = txtYeniEpostaAdresi.Text;

            try
            {
                if(_userManager.UpdateEmail(uivm, willUpdateemail)!=null)
                {
                    MessageBox.Show("E-mailiniz Başarıyla Güncellenmiştir.");
                }
                else
                {
                    MessageBox.Show("Bu eposta başka biri tarafından kullanılıyor.");
                }                            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Yenile();
            }
        }

        private List<ProductUserAddedVM> products;
        private void EkledigimUrunleriGetir()
        {
            lwEkledigimUrunler.Items.Clear();
            ProductUserAddedVM productUserAddedVM = new ProductUserAddedVM();
            products = _productManager.GetProductsByUserAdded(_userDetailVM.UserRoleID);

            foreach (var arass in products)
            {

                ListViewItem item = new ListViewItem(arass.UrunAdi); 
                item.SubItems.Add(arass.TakipNumarasi); 
                item.SubItems.Add(arass.OnayDurumu.HasValue ? (arass.OnayDurumu.Value ? "Onaylandı" : "Beklemede") : "Bilinmiyor");
                item.SubItems.Add(arass.BarkodNumarasi); 
                lwEkledigimUrunler.Items.Add(item);
                if (arass.OnayDurumu.HasValue && arass.OnayDurumu.Value)
                {
                    item.ForeColor = Color.Green;
                }
                else
                {
                    item.ForeColor = Color.Red;
                }
            }
        }

        private void btnListeOlustur_Click(object sender, EventArgs e)
        {
            UserAddListInsertVM addList = new UserAddListInsertVM { ListeAdi = txtListeAdi.Text, UserRoleID = _userDetailVM.UserRoleID };

            
            _userManager.AddListByUser(addList,_userDetailVM);
            cmbListelerim.Items.Clear();
            cmbListelerim.Items.AddRange(_userManager.GetUserLists(_userDetailVM.UserRoleID).ToArray());
            MessageBox.Show("Liste olusturuldu.");
            txtListeAdi.Text = string.Empty;


        }

        private void cmbListelerim_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserAddListInsertVM userAddListInsertVM = (cmbListelerim.SelectedItem as UserAddListInsertVM);
            if (userAddListInsertVM != null)
            {
                List<UserListItemSelectVM> listeIcerikleri = userAddListInsertVM.ListeIcerik as List<UserListItemSelectVM>;

                lstFavoriListe.Items.Clear();
                lstFavoriListe.Items.AddRange(listeIcerikleri.ToArray());
            }                      
        }

        private void txtFiltreAra_TextChanged(object sender, EventArgs e)
        {
            Yenile();
            string seciliKolon = cmbFiltre.SelectedItem.ToString();
            string aranaKelime = txtFiltreAra.Text.ToLower();

            List<ListViewItem> eslesenler = new List<ListViewItem>();

            foreach (ListViewItem item in lwEkledigimUrunler.Items)
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

            lwEkledigimUrunler.Items.Clear();

            foreach (ListViewItem item in eslesenler)
            {
                lwEkledigimUrunler.Items.Add(item);
            }
        }

        private void btnUcretsizPremium_Click(object sender, EventArgs e)
        {
            if (userPoint > 25)
            {
                MessageBox.Show("Tebrikler Premium oldunuz!!!");
                _userManager.UpdateUser(new UserSelectVM { ID = _userDetailVM.ID });
            }
            else
            {
                MessageBox.Show("Premium olmak icin yeterli puanınız yok");
            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.DoDragDrop(listBox1.SelectedItem, DragDropEffects.All);
            }
        }

        private void lstKaraListe_DragDrop(object sender, DragEventArgs e)
        {
            IngredientSelectVM draggedItem = (IngredientSelectVM)e.Data.GetData(typeof(IngredientSelectVM));

            if(_userManager.AddUserBlackListItem(new UserBlackListInsertVM { KullaniciRolID = _userDetailVM.UserRoleID }, new UserListItemInsertVM { IcerikID = draggedItem.ID }))
            {
                lstKaraListe.Items.Add(draggedItem);
                listBox1.Items.Remove(draggedItem);
            }
            else
            {
                MessageBox.Show("Hata oluştu");
            }
        }

        private void lstKaraListe_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(IngredientSelectVM)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void btnKaraListedenCikar_Click(object sender, EventArgs e)
        {
            IngredientSelectVM blackListItem = lstKaraListe.SelectedItem as IngredientSelectVM;

            if (blackListItem != null)
            {
                _userManager.DeleteUserBlackListItem(new UserListItemSelectVM { IcerikID = blackListItem.ID }, _userDetailVM);
            }
            else
            {
                UserListItemSelectVM blackListItemm = lstKaraListe.SelectedItem as UserListItemSelectVM;
                if (blackListItemm != null)
                {
                    _userManager.DeleteUserBlackListItem(new UserListItemSelectVM { IcerikID = blackListItemm.IcerikID }, _userDetailVM);
                }               
            }
            KaraListeYenile();
        }

        private void KaraListeYenile()
        {
            lstKaraListe.Items.Clear();
            lstKaraListe.Items.AddRange(_userManager.GetUserBlackListItems(_userDetailVM).ToArray());
        }

        private void btnSeciliListeyiSil_Click(object sender, EventArgs e)
        {
            UserAddListInsertVM favoriListe = cmbListelerim.SelectedItem as UserAddListInsertVM;
            if (favoriListe != null)
            {
                if (lstFavoriListe.Items.Count!=0)
                {
					DialogResult result = MessageBox.Show("Bu listede ürün var, silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (result == DialogResult.Yes)
					{
						_userManager.DeleteUserFavoriteList(favoriListe, _userDetailVM);
                        MessageBox.Show("Liste basarıyla silindi.");
                    }
                    else
                    {
                        return;
                    }
				}
				_userManager.DeleteUserFavoriteList(favoriListe, _userDetailVM);
				MessageBox.Show("Liste basarıyla silindi.");
				lstFavoriListe.Items.Clear();
                cmbListelerim.Items.Clear();
                cmbListelerim.Items.AddRange(_userManager.GetUserLists(_userDetailVM.UserRoleID).ToArray());
            }   
        }

        private void btnFavoridenCikar_Click(object sender, EventArgs e)
        {
            UserListItemSelectVM favoriItem = lstFavoriListe.SelectedItem as UserListItemSelectVM;
            UserAddListInsertVM favoriListe = cmbListelerim.SelectedItem as UserAddListInsertVM;
            if (favoriItem !=null && favoriListe != null)
            {
                _userManager.DeleteUserFavoriteListItem(favoriListe, favoriItem, _userDetailVM);
                // buraya bakılması lazım 
                lstFavoriListe.Items.Remove(lstFavoriListe.SelectedItem);
                cmbListelerim.Items.Clear();
                cmbListelerim.Items.AddRange(_userManager.GetUserLists(_userDetailVM.UserRoleID).ToArray());
            }
        }

    }
}
