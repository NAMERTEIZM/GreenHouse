using GreenHouse.Core;
using GreenHouse.VM.Page;
using GreenHouse.VM.User;
using MyEfSample.DAL.Mapper;
using MyEFSample.DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace GreenHouse.DAL.LogicsDAL
{
    public class UserDAL
    {
        public List<UserSelectVM> GetUser()
        {
            EFRepo<Kullanici> userDAL = new EFRepo<Kullanici>(new GreenHouseContext());

            List<Kullanici> users = userDAL.SelectAllWithInclude("KullaniciRolus.Rol");

            List<UserSelectVM> uservms = new List<UserSelectVM>();

            users.ForEach(x =>
            {
                KullaniciRolu krol = x.KullaniciRolus.LastOrDefault() as KullaniciRolu;
                if (krol != null)
                {
                    Rol rol = krol.Rol as Rol;

                    if (rol != null)
                    {
                        RoleSelectVM roleSelectVM = new RoleSelectVM { ID = rol.ID, RolAdi = rol.RolAdi };

                        uservms.Add(new UserSelectVM
                        {
                            ID = x.ID,
                            Adi = x.Adi,
                            Email = x.Email,
                            Soyadi = x.Soyadi,
                            EmailOnayliMi = x.EmailOnayliMi,
                            PasswordHash = x.PasswordHash,
                            Rol = roleSelectVM,
                            AktifMi = x.AktifMi,
                            AdminOnaylimi = x.AdminOnayliMi,
                            PremiumMu = x.PremiumMu

                        });
                    }

                }
            });

            return uservms;
        }

        public UserInsertVM AddUser(UserInsertVM userInsertVM)
        {
            using (var scope = new TransactionScope())
            {
                EFRepo<Kullanici> userDAL = new EFRepo<Kullanici>(new GreenHouseContext());
                EFRepo<KullaniciRolu> userRoleDAL = new EFRepo<KullaniciRolu>(new GreenHouseContext());

                Kullanici userEntity = userDAL.SelectAll(x => x.Email == userInsertVM.Email).SingleOrDefault();

                if (userEntity == null)
                {
                    Guid guid = Guid.NewGuid();
                    Kullanici user = new Kullanici
                    {
                        ID = guid,
                        Adi = userInsertVM.Adi,
                        Soyadi = userInsertVM.Soyadi,
                        Email = userInsertVM.Email,
                        PasswordHash = userInsertVM.PasswordHash,
                        AktifMi = userInsertVM.AktifMi,
                        EmailOnayliMi = userInsertVM.EmailOnayliMi,
                    };
                    userDAL.Add(user);

                    Guid kguid = Guid.NewGuid();
                    KullaniciRolu kr = new KullaniciRolu
                    {
                        ID = kguid,
                        KullaniciID = guid,
                        RolID = userInsertVM.Rol.ID

                    };
                    userRoleDAL.Add(kr);

                    scope.Complete();
                }
                scope.Dispose();
            }

            return userInsertVM;
        }

        public UserSelectVM UpdateUser(UserSelectVM userInsertVM)
        {
            using (var scope = new TransactionScope())
            {
                EFRepo<Kullanici> userDAL = new EFRepo<Kullanici>(new GreenHouseContext());

                MyEntityMapper<UserSelectVM, Kullanici> mapper = new MyEntityMapper<UserSelectVM, Kullanici>();
                Kullanici user = mapper.Map<UserSelectVM, Kullanici>(userInsertVM);

                userDAL.Update(user);
                scope.Complete();
            }

            return userInsertVM;
        }

        public UserSelectVM DeleteUser(UserSelectVM userInsertVM)
        {
            using (var scope = new TransactionScope())
            {
                EFRepo<Kullanici> userDAL = new EFRepo<Kullanici>(new GreenHouseContext());

                MyEntityMapper<UserSelectVM, Kullanici> mapper = new MyEntityMapper<UserSelectVM, Kullanici>();
                Kullanici user = mapper.Map<UserSelectVM, Kullanici>(userInsertVM);

                userDAL.SoftDelete(user);
                scope.Complete();
            }

            return userInsertVM;
        }
        public UserInsertVM UpdatePassword(UserInsertVM passwordUpdateVM, string willUpdatePass)
        {
            EFRepo<Kullanici> userDAL = new EFRepo<Kullanici>(new GreenHouseContext());

            Kullanici existingUser = userDAL.SelectAll(x => x.ID == passwordUpdateVM.ID).SingleOrDefault();

            if (existingUser != null)
            {
                existingUser.PasswordHash = willUpdatePass;

                userDAL.Update(existingUser);


            }
            return passwordUpdateVM;
        }

        public UserInsertVM UpdateEmail(UserInsertVM emailUpdateVM, string willUpdateemail)
        {
            EFRepo<Kullanici> userDAL = new EFRepo<Kullanici>(new GreenHouseContext());
            Kullanici user = userDAL.SelectAll(x => x.Email == willUpdateemail).SingleOrDefault();
            if (user != null)
            {
                return null;
            }

            Kullanici existingUser = userDAL.SelectAll(x => x.ID == emailUpdateVM.ID).SingleOrDefault();

            if (existingUser != null)
            {
                existingUser.Email = willUpdateemail;
                userDAL.Update(existingUser);
            }
            return emailUpdateVM;
        }

        public UserAddListInsertVM AddListByUser(UserAddListInsertVM userAddListSelectVM, UserDetailVM userDetailVM)
        {
            EFRepo<KullaniciListesi> userDAL = new EFRepo<KullaniciListesi>(new GreenHouseContext());

            List<KullaniciListesi> kullaniciListesi = userDAL.SelectAllWithInclude(x => x.KullaniciRolID == userAddListSelectVM.UserRoleID, "KullaniciRolu", "ListeTip");

            foreach (var x in kullaniciListesi)
            {
                if (x.ListeAdi == userAddListSelectVM.ListeAdi)
                {
                    return new UserAddListInsertVM { };
                }
            }
            Guid guid = Guid.NewGuid();
            ListeTip lstType = new ListeTip { TipAdi = "Favori Liste", ID = 1 };
            userDAL.Add(new KullaniciListesi { ID = guid, ListeAdi = userAddListSelectVM.ListeAdi, ListeTip = lstType, KullaniciRolID = userDetailVM.UserRoleID });

            return userAddListSelectVM;
        }

        public List<UserListTypeSelectVM> GetListType()
        {
            EFRepo<ListeTip> listTypeDAL = new EFRepo<ListeTip>(new GreenHouseContext());

            List<ListeTip> lists = listTypeDAL.SelectAll();

            List<UserListTypeSelectVM> userListTypeSelectVMs = new List<UserListTypeSelectVM>();
            lists.ForEach(x =>
            {
                MyEntityMapper<ListeTip, UserListTypeSelectVM> mapper = new MyEntityMapper<ListeTip, UserListTypeSelectVM>();
                UserListTypeSelectVM listetip = mapper.Map<ListeTip, UserListTypeSelectVM>(x);
                userListTypeSelectVMs.Add(listetip);
            });

            return userListTypeSelectVMs;
        }

        public List<UserAddListInsertVM> GetUserLists(Guid userRoleID)
        {
            ProductDAL productManager = new ProductDAL();
            EFRepo<KullaniciListesi> userDAL = new EFRepo<KullaniciListesi>(new GreenHouseContext());

            List<KullaniciListesi> kullaniciListesi = userDAL.SelectAllWithInclude(x => x.KullaniciRolID == userRoleID && x.ListeTip.TipAdi != "Kara Liste", "KullaniciRolu", "ListeTip", "ListeIcerigis");

            List<UserAddListInsertVM> userAddListInsertVMs = new List<UserAddListInsertVM>();
            kullaniciListesi.ForEach(x =>
            {
                List<UserListItemSelectVM> userListItemSelectVMs = new List<UserListItemSelectVM>();
                foreach (var item in x.ListeIcerigis)
                {
                    if (item.UrunMu.HasValue && item.UrunMu.Value)
                    {
                        Urun product = productManager.GetProductByID(item.IcerikID);
                        if (product != null)
                        {
                            userListItemSelectVMs.Add(new UserListItemSelectVM { IcerikID = item.IcerikID, ID = item.ID, ListeID = item.ListeID, UrunMu = item.UrunMu, IcerikAdi = product.UrunAdi });
                        }

                    }
                }

                UserListTypeSelectVM lstType = new UserListTypeSelectVM { TipAdi = x.ListeTip.TipAdi, ID = x.ListeTip.ID };
                UserAddListInsertVM lst = new UserAddListInsertVM { ListeAdi = x.ListeAdi, ListeTipi = lstType, ListeIcerik = userListItemSelectVMs, ID = x.ID };
                userAddListInsertVMs.Add(lst);
            });

            return userAddListInsertVMs;
        }

        public int GetUserPoint(Guid userRoleID)
        {
            EFRepo<UrunOnay> urunOnayDal = new EFRepo<UrunOnay>(new GreenHouseContext());

            List<UrunOnay> onaylananUrunler = urunOnayDal.SelectAllWithInclude(x => x.EkleyenKullaniciRolID == userRoleID).Where(x => x.OnayDurumu == true).ToList();
            return onaylananUrunler.Count();
        }

        public bool AddUserBlackListItem(UserBlackListInsertVM userBlackListInsertVM, UserListItemInsertVM userListItemInsertVM)
        {
            try
            {
                EFRepo<KullaniciListesi> userListDal = new EFRepo<KullaniciListesi>(new GreenHouseContext());

                KullaniciListesi userBlackList = userListDal.SelectAllWithInclude(x => x.KullaniciRolID == userBlackListInsertVM.KullaniciRolID && x.ListeTip.TipAdi == "Kara Liste", "KullaniciRolu", "ListeTip", "ListeIcerigis").SingleOrDefault();

                if (userBlackList == null)
                {
                    Guid guid = Guid.NewGuid();
                    KullaniciListesi userList = new KullaniciListesi { ID = guid, ListeAdi = "Kara Liste", KullaniciRolID = userBlackListInsertVM.KullaniciRolID, ListeTipiID = 2 };

                    userListDal.Add(userList);
                }

                EFRepo<ListeIcerigi> listItemDal = new EFRepo<ListeIcerigi>(new GreenHouseContext());
                KullaniciListesi userBlackListt = userListDal.SelectAllWithInclude(x => x.KullaniciRolID == userBlackListInsertVM.KullaniciRolID && x.ListeTip.TipAdi == "Kara Liste", "KullaniciRolu", "ListeTip", "ListeIcerigis").SingleOrDefault();

                Guid guiditem = Guid.NewGuid();
                ListeIcerigi listItem = new ListeIcerigi { ID = guiditem, ListeID = userBlackListt.ID, IcerikID = userListItemInsertVM.IcerikID, UrunMu = true };

                listItemDal.Add(listItem);
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        public List<UserListItemSelectVM> GetUserBlackListItems(UserDetailVM userDetailVM)
        {
            EFRepo<KullaniciListesi> userListDal = new EFRepo<KullaniciListesi>(new GreenHouseContext());
            IngredientDAL ingredientDAL = new IngredientDAL();
            KullaniciListesi userBlackList = userListDal.SelectAllWithInclude(x => x.ListeTip.TipAdi == "Kara Liste" && x.KullaniciRolID == userDetailVM.UserRoleID, "KullaniciRolu", "ListeTip", "ListeIcerigis").SingleOrDefault();

            List<UserListItemSelectVM> blackList = new List<UserListItemSelectVM>();

            if (userBlackList != null)
            {
                foreach (var item in userBlackList.ListeIcerigis)
                {
                    Bilesen ingredient = ingredientDAL.GetIngredientByID(item.IcerikID);
                    blackList.Add(new UserListItemSelectVM { IcerikID = item.IcerikID, ListeID = item.ListeID, IcerikAdi = ingredient.Adi, UrunMu = item.UrunMu, ID = item.ID });
                }
            }

            return blackList;
        }

        public bool DeleteUserBlackListItem(UserListItemSelectVM userListItemSelectVM, UserDetailVM userDetailVM)
        {
            try
            {
                EFRepo<KullaniciListesi> userListDal = new EFRepo<KullaniciListesi>(new GreenHouseContext());
                KullaniciListesi userBlackList = userListDal.SelectAllWithInclude(x => x.ListeTip.TipAdi == "Kara Liste" && x.KullaniciRolID == userDetailVM.UserRoleID, "KullaniciRolu", "ListeTip", "ListeIcerigis").SingleOrDefault();

                EFRepo<ListeIcerigi> listItemDal = new EFRepo<ListeIcerigi>(new GreenHouseContext());

                foreach (var item in userBlackList.ListeIcerigis)
                {
                    if (item.IcerikID == userListItemSelectVM.IcerikID)
                    {
                        listItemDal.HardDelete(new ListeIcerigi { ID = item.ID });

                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool AddUserFavoriteListItem(UserAddListInsertVM userAddListInsertVM, Guid productID, UserDetailVM userDetailVM)
        {
            try
            {
                EFRepo<KullaniciListesi> userListDal = new EFRepo<KullaniciListesi>(new GreenHouseContext());
                KullaniciListesi userFavoriteList = userListDal.SelectAllWithInclude(x => userAddListInsertVM.ID == x.ID, "KullaniciRolu", "ListeTip", "ListeIcerigis").SingleOrDefault();

                EFRepo<ListeIcerigi> listItemDal = new EFRepo<ListeIcerigi>(new GreenHouseContext());
                Guid guid = Guid.NewGuid();

                ListeIcerigi listItem = new ListeIcerigi { ID = guid, IcerikID = productID, ListeID = userAddListInsertVM.ID, UrunMu = true };
                listItemDal.Add(listItem);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool DeleteUserFavoriteListItem(UserAddListInsertVM userAddListInsertVM, UserListItemSelectVM userListItemSelectVM, UserDetailVM userDetailVM)
        {
            try
            {
                EFRepo<KullaniciListesi> userListDal = new EFRepo<KullaniciListesi>(new GreenHouseContext());
                KullaniciListesi userFavoriteList = userListDal.SelectAllWithInclude(x => userAddListInsertVM.ID == x.ID, "KullaniciRolu", "ListeTip", "ListeIcerigis").SingleOrDefault();

                EFRepo<ListeIcerigi> listItemDal = new EFRepo<ListeIcerigi>(new GreenHouseContext());

                foreach (var item in userFavoriteList.ListeIcerigis)
                {
                    if (item.IcerikID == userListItemSelectVM.IcerikID)
                    {
                        listItemDal.HardDelete(new ListeIcerigi { ID = item.ID });
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool DeleteUserFavoriteList(UserAddListInsertVM userAddListInsertVM, UserDetailVM userDetailVM)
        {
            using (var context = new GreenHouseContext())
            using (var scope = new TransactionScope())
            {
                try
                {
                    EFRepo<KullaniciListesi> userListDal = new EFRepo<KullaniciListesi>(context);
                    EFRepo<ListeIcerigi> listItemDal = new EFRepo<ListeIcerigi>(context);
                    KullaniciListesi userFavoriteList = userListDal.SelectAllWithInclude(x => userAddListInsertVM.ID == x.ID, "KullaniciRolu", "ListeTip", "ListeIcerigis").SingleOrDefault();

                    if (userFavoriteList == null)
                    {
                        return false;
                    }

                    var itemsToDelete = userFavoriteList.ListeIcerigis.ToList();
                    foreach (var item in itemsToDelete)
                    {
                        listItemDal.HardDelete(item);
                    }

                    userListDal.HardDelete(userFavoriteList);

                    scope.Complete();
                }
                catch (Exception ex)
                {
                    scope.Dispose();
                    return false;
                }
                return true;
            }
        }

    }
}
