using GreenHouse.Core;
using GreenHouse.VM.Company;
using GreenHouse.VM.Page;
using MyEFSample.DAL.Concrete;
using MyEfSample.DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenHouse.VM.Role;
using GreenHouse.VM.Authorizon;

namespace GreenHouse.DAL.LogicsDAL
{
    public class RoleDAL
    {
        public List<RoleSelectVM> GetRole()
        {
            EFRepo<Rol> roleDAL = new EFRepo<Rol>(new GreenHouseContext());
            List<Rol> roles = roleDAL.SelectAll().ToList();

            List<RoleSelectVM> rolevm = new List<RoleSelectVM>();

            MyEntityMapper<Rol, RoleSelectVM> mapper = new MyEntityMapper<Rol, RoleSelectVM>();
            foreach (var role in roles)
            {
                RoleSelectVM company = mapper.Map<Rol, RoleSelectVM>(role);

                rolevm.Add(company);
            }
            return rolevm;
        }

        public RoleInsertVM AddRole(RoleInsertVM roleInsertVM)
        {
            EFRepo<Rol> rolDAL = new EFRepo<Rol>(new GreenHouseContext());

            MyEntityMapper<RoleInsertVM, Rol> mapper = new MyEntityMapper<RoleInsertVM, Rol>();
            Rol role = mapper.Map<RoleInsertVM, Rol>(roleInsertVM);
            rolDAL.Add(role);
            return roleInsertVM;
        }

        public RoleSelectVM UpdateRole(RoleSelectVM roleSelectVM)
        {
            EFRepo<Rol> rolDAL = new EFRepo<Rol>(new GreenHouseContext());

            MyEntityMapper<RoleSelectVM, Rol> mapper = new MyEntityMapper<RoleSelectVM, Rol>();
            Rol role = mapper.Map<RoleSelectVM, Rol>(roleSelectVM);
            rolDAL.Update(role);
            return roleSelectVM;
        }
        public RoleSelectVM DeleteRole(RoleSelectVM roleSelectVM)
        {
            EFRepo<Rol> rolDAL = new EFRepo<Rol>(new GreenHouseContext());

            MyEntityMapper<RoleSelectVM, Rol> mapper = new MyEntityMapper<RoleSelectVM, Rol>();
            Rol role = mapper.Map<RoleSelectVM, Rol>(roleSelectVM);
            rolDAL.SoftDelete(role);
            return roleSelectVM;
        }

        public List<PageAuthorizationVM> GetRolWithAll()
        {
            EFRepo<SayfaYetki> sayfaYetki = new EFRepo<SayfaYetki>(new GreenHouseContext());
            List<SayfaYetki> sayfaYetkis = sayfaYetki.SelectAllWithInclude("Sayfa", "Yetki", "Rol").ToList();
            List<PageAuthorizationVM> sayfaYetkileri = new List<PageAuthorizationVM>();
            foreach (var item in sayfaYetkis)
            {
                AuthorizonSelectVM authorizon = new AuthorizonSelectVM { ID = item.Yetki.ID, Adi = item.Yetki.Adi };
                RoleSelectVM role = new RoleSelectVM { ID = item.Rol.ID, RolAdi = item.Rol.RolAdi };
                PageSelectVM page = new PageSelectVM { ID = item.Sayfa.ID, SayfaAdi = item.Sayfa.SayfaAdi };
                sayfaYetkileri.Add(new PageAuthorizationVM { ID = item.ID, Authorizon = authorizon, Role = role, Page = page });

            }
            return sayfaYetkileri;
        }
        public bool ChangePageAuthorizon(PageAuthorizationInsertVM data)
        {
            try
            {
                EFRepo<SayfaYetki> sayfaYetkiDAL = new EFRepo<SayfaYetki>(new GreenHouseContext());

                List<SayfaYetki> sayfaYetkis2 = sayfaYetkiDAL.SelectAll().Where(x => x.SayfaID == data.SayfaID && x.RolID == data.RolID && x.YetkiID == data.YetkiID).ToList();
                if (sayfaYetkis2.Count > 0)
                {
                    return false;
                }

                MyEntityMapper<PageAuthorizationInsertVM, SayfaYetki> mapper = new MyEntityMapper<PageAuthorizationInsertVM, SayfaYetki>();
                SayfaYetki sayfaYetki = mapper.Map<PageAuthorizationInsertVM, SayfaYetki>(data);
                sayfaYetkiDAL.Add(sayfaYetki);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeletePageAuthorizon(PageAuthorizationInsertVM data)
        {
            try
            {
                EFRepo<SayfaYetki> sayfaYetkiDAL = new EFRepo<SayfaYetki>(new GreenHouseContext());

                List<SayfaYetki> sayfaYetkis2 = sayfaYetkiDAL.SelectAllWithAsNoTracking().Where(x=> x.ID == data.ID).ToList();
                if (sayfaYetkis2.Count < 1)
                {
                    return false;
                }

                MyEntityMapper<PageAuthorizationInsertVM, SayfaYetki> mapper = new MyEntityMapper<PageAuthorizationInsertVM, SayfaYetki>();
                SayfaYetki sayfaYetki = mapper.Map<PageAuthorizationInsertVM, SayfaYetki>(data);
                sayfaYetkiDAL.HardDelete(sayfaYetki);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
