using GreenHouse.Core;
using GreenHouse.VM.User;
using GreenHouse.VM;
using MyEFSample.DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace GreenHouse.DAL.LogicsDAL
{
    public class LoginDAL
    {
        private Dictionary<string, List<string>> permissionPages = new Dictionary<string, List<string>>();

        // Kullanıcı girişi işlemi
        public Dictionary<string, List<string>> Login(UserVM user)
        {
            EFRepo<Kullanici> userdb = new EFRepo<Kullanici>();
            Kullanici userEntity = userdb.SelectAllWithInclude(x => x.Email == user.Email, "KullaniciRolus.Rol.SayfaYetkis.Sayfa", "KullaniciRolus.Rol.SayfaYetkis.Yetki").SingleOrDefault();
            if (userEntity != null)
            {
                KullaniciRolu kr = userEntity.KullaniciRolus.LastOrDefault() as KullaniciRolu;
                Rol rol = kr.Rol as Rol;

                if (userEntity != null && userEntity.PasswordHash == user.PasswordHash)
                {
                    foreach (var userRole in userEntity.KullaniciRolus)
                    {
                        foreach (var pagePermission in userRole.Rol.SayfaYetkis)
                        {
                            string permissionKey = pagePermission.Yetki.Adi;
                            string pageName = pagePermission.Sayfa.SayfaAdi;

                            if (!permissionPages.ContainsKey(permissionKey))
                            {
                                permissionPages[permissionKey] = new List<string>();
                            }

                            permissionPages[permissionKey].Add(pageName);
                        }
                    }
                    return permissionPages;
                }
            }

            return null;
        }

        // Belirli bir yetkiye ait sayfaları al
        public List<string> GetPagesForPermission(string permissionKey)
        {
            if (permissionPages.ContainsKey(permissionKey))
            {
                return permissionPages[permissionKey];
            }

            return new List<string>();
        }

        public UserDetailVM UserLogin(UserLoginVM uservm)
        {
            EFRepo<Kullanici> userdb = new EFRepo<Kullanici>();
            Kullanici userEntity = userdb.SelectAllWithInclude(x => x.Email == uservm.Email, "KullaniciRolus").SingleOrDefault();



            if (userEntity != null && userEntity.PasswordHash == uservm.PasswordHash && userEntity.EmailOnayliMi == true)
            {
                UserDetailVM userDetailVM = new UserDetailVM { ID = userEntity.ID, Adi = userEntity.Adi, Soyadi = userEntity.Soyadi, Email = userEntity.Email, PasswordHash = userEntity.PasswordHash, UserRoleID = userEntity.KullaniciRolus.LastOrDefault().ID, OlusturulmaTarihi = userEntity.OlusturulmaTarihi };

                return userDetailVM;
            }
            return null;
        }

        public bool UserRegister(UserVM uservm)
        {
            using (var scope = new TransactionScope())
            {
                try
                {
                    EFRepo<Kullanici> userdb = new EFRepo<Kullanici>();
                    Kullanici userEntity = userdb.SelectAll(x => x.Email == uservm.Email).SingleOrDefault();
                    Random random = new Random();
                    int code = random.Next(100000, 1000000);

                    if (userEntity == null)
                    {
                        Guid guid = Guid.NewGuid();
                        Kullanici user = new Kullanici
                        {
                            ID = guid,
                            Adi = uservm.Adi,
                            Soyadi = uservm.Soyadi,
                            Email = uservm.Email,
                            PasswordHash = uservm.PasswordHash,
                            EmailOnayliMi = true,
                            AktifMi = true,
                            EmailKod = code.ToString(),
                            OlusturulmaTarihi = DateTime.Now,
                        };

                        userEntity = userdb.Add(user);

                        EFRepo<KullaniciRolu> userRoleDAL = new EFRepo<KullaniciRolu>();

                        Guid userRoleGuid = Guid.NewGuid();

                        KullaniciRolu userRole = new KullaniciRolu
                        {
                            ID = userRoleGuid,
                            KullaniciID = guid,
                            RolID = 3
                        };

                        userRoleDAL.Add(userRole);

                        /*

                        Email onaylama hazır

                        SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                        smtpClient.Port = 587;
                        smtpClient.Credentials = new NetworkCredential("paradoxfurkan@gmail.com", "hesap_sifresi_silindi");
                        smtpClient.EnableSsl = true;
                        MailMessage mailMessage = new MailMessage();
                        mailMessage.From = new MailAddress("paradoxfurkan@gmail.com");
                        mailMessage.To.Add(user.Email);
                        mailMessage.Subject = "YesilEV Onay Kodu";
                        mailMessage.Body = "Kayıt işlemi gerçekleştirmek için onay kodunuz: " + code;
                        smtpClient.Send(mailMessage);

                        */

                        scope.Complete();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    scope.Dispose();
                    throw;
                }


                return false;
            }
        }
    }
}
