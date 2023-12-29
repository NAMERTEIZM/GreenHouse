using GreenHouse.Core;
using GreenHouse.VM.Company;
using MyEFSample.DAL.Concrete;
using MyEfSample.DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenHouse.VM.Authorizon;
using GreenHouse.DAL.LogicsDAL;

namespace GreenHouse.BLL.Logic
{
	public class AuthorizonManager
	{
		AuthorizonDAL AuthorizonDAL;
        public AuthorizonManager()
		{
            AuthorizonDAL = new AuthorizonDAL();
        }
		
        public List<AuthorizonSelectVM> GetAuthorizon()
		{
			return AuthorizonDAL.GetAuthorizon();
		}

		public AuthorizonInsertVM AddAuthorizon(AuthorizonInsertVM authorizon)
		{
			return AuthorizonDAL.AddAuthorizon(authorizon);
		}

		public AuthorizonUpdateVM UpdateAuthorizon(AuthorizonUpdateVM authorizon)
		{
			return AuthorizonDAL.UpdateAuthorizon(authorizon);
		}

		public AuthorizonDeleteVM DeleteAuthorizon(AuthorizonDeleteVM authorizon)
		{
			return AuthorizonDAL.DeleteAuthorizon(authorizon);
		}
	}
}
