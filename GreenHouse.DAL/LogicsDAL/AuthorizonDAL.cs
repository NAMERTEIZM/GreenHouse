using GreenHouse.Core;
using GreenHouse.VM.Authorizon;
using MyEFSample.DAL.Concrete;
using MyEfSample.DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.DAL.LogicsDAL
{
    public class AuthorizonDAL
    {
        public List<AuthorizonSelectVM> GetAuthorizon()
        {
            EFRepo<Yetki> companyDAL = new EFRepo<Yetki>(new GreenHouseContext());

            List<Yetki> yetkiler = companyDAL.SelectAll().ToList();
            //dondurecegimiz select listesi
            List<AuthorizonSelectVM> authorizonvm = new List<AuthorizonSelectVM>();

            MyEntityMapper<Yetki, AuthorizonSelectVM> mapper = new MyEntityMapper<Yetki, AuthorizonSelectVM>();
            //gelen yetkileri gezer vm listesine ekler
            foreach (var yetki in yetkiler)
            {
                AuthorizonSelectVM authorizon = mapper.Map<Yetki, AuthorizonSelectVM>(yetki);
                authorizonvm.Add(authorizon);
            }
            return authorizonvm;
        }

        public AuthorizonInsertVM AddAuthorizon(AuthorizonInsertVM authorizon)
        {
            try
            {
                EFRepo<Yetki> companyDal = new EFRepo<Yetki>(new GreenHouseContext());
                MyEntityMapper<AuthorizonInsertVM, Yetki> mapper = new MyEntityMapper<AuthorizonInsertVM, Yetki>();
                Yetki yetki = mapper.Map<AuthorizonInsertVM, Yetki>(authorizon);

                companyDal.Add(yetki);
            }
            catch (Exception)
            {
                throw;
            }
            return authorizon;
        }

        public AuthorizonUpdateVM UpdateAuthorizon(AuthorizonUpdateVM authorizon)
        {
            EFRepo<Yetki> yetkiDal = new EFRepo<Yetki>(new GreenHouseContext());

            MyEntityMapper<AuthorizonUpdateVM, Yetki> mapper = new MyEntityMapper<AuthorizonUpdateVM, Yetki>();
            Yetki yetki = mapper.Map<AuthorizonUpdateVM, Yetki>(authorizon);

            yetkiDal.Update(yetki);

            return authorizon;
        }

        public AuthorizonDeleteVM DeleteAuthorizon(AuthorizonDeleteVM authorizon)
        {
            EFRepo<Yetki> yetkiDal = new EFRepo<Yetki>(new GreenHouseContext());

            MyEntityMapper<AuthorizonDeleteVM, Yetki> mapper = new MyEntityMapper<AuthorizonDeleteVM, Yetki>();
            Yetki yetki = mapper.Map<AuthorizonDeleteVM, Yetki>(authorizon);

            yetkiDal.HardDelete(yetki);

            return authorizon;
        }
    }
}
