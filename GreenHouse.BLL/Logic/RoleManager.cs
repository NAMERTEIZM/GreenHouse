using GreenHouse.Core;
using GreenHouse.VM.Company;
using MyEFSample.DAL.Concrete;
using MyEfSample.DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenHouse.VM.Page;
using System.Data;
using GreenHouse.DAL.LogicsDAL;
using GreenHouse.VM.Role;

namespace GreenHouse.BLL.Logic
{
    public class RoleManager
    {
        RoleDAL RoleDAL;

        public RoleManager()
        {
            RoleDAL = new RoleDAL();
        }

        public List<RoleSelectVM> GetRole()
        {
            return RoleDAL.GetRole();
        }

        public RoleInsertVM AddRole(RoleInsertVM roleInsertVM)
        {
            return RoleDAL.AddRole(roleInsertVM);
        }

        public RoleSelectVM UpdateRole(RoleSelectVM roleSelectVM)
        {
            return RoleDAL.UpdateRole(roleSelectVM);
        }
        public RoleSelectVM DeleteRole(RoleSelectVM roleSelectVM)
        {
            return RoleDAL.DeleteRole(roleSelectVM);
        }

        public List<PageAuthorizationVM> GetRoleWithAll()
        {
            return RoleDAL.GetRolWithAll();
        }

        public bool ChangePageAuthorizon(PageAuthorizationInsertVM data)
        {
            return RoleDAL.ChangePageAuthorizon(data);
        }

        public bool DeletePageAuthorizon(PageAuthorizationInsertVM data)
        {
            return RoleDAL.DeletePageAuthorizon(data);
        }
    }
}
