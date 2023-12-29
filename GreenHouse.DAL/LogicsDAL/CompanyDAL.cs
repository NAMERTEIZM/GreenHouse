using GreenHouse.Core;
using GreenHouse.VM.Company;
using MyEFSample.DAL.Concrete;
using MyEfSample.DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.DAL.LogicsDAL
{
    public class CompanyDAL
    {
        public List<CompanySelectVM> GetCompany()
        {
            EFRepo<Firma> companyDAL = new EFRepo<Firma>(new GreenHouseContext());
            List<Firma> firmalar = companyDAL.SelectAll().Where(a => a.AktifMi == true).ToList();
            //dondurecegimiz select listesi
            List<CompanySelectVM> companyvm = new List<CompanySelectVM>();

            MyEntityMapper<Firma, CompanySelectVM> mapper = new MyEntityMapper<Firma, CompanySelectVM>();
            foreach (var firma in firmalar)
            {
                CompanySelectVM company = mapper.Map<Firma, CompanySelectVM>(firma);

                companyvm.Add(company);
            }
            return companyvm;

            //return companyDAL.SelectAll().Where(a => a.AktifMi == true).Select(a => new CompanySelectVM()
            //{
            //    ID = a.ID,
            //    FirmaAdi = a.FirmaAdi,
            //    FirmaAdresi = a.FirmaAdresi,
            //    FirmaTel=a.FirmaTel,
            //    AktifMi = a.AktifMi,
            //}).ToList();

        }

        public CompanyInsertVM AddCompany(CompanyInsertVM company)
        {
            try
            {
                EFRepo<Firma> companyDal = new EFRepo<Firma>(new GreenHouseContext());
                Guid guid = Guid.NewGuid();
                company.ID = guid;
                MyEntityMapper<CompanyInsertVM, Firma> mapper = new MyEntityMapper<CompanyInsertVM, Firma>();
                Firma firma = mapper.Map<CompanyInsertVM, Firma>(company);

                companyDal.Add(firma);
            }
            catch (Exception)
            {
                throw;
            }
            return company;
        }

        public CompanyUpdateVM UpdateCompany(CompanyUpdateVM company)
        {
            EFRepo<Firma> companyDal = new EFRepo<Firma>(new GreenHouseContext());

            MyEntityMapper<CompanyUpdateVM, Firma> mapper = new MyEntityMapper<CompanyUpdateVM, Firma>();
            Firma firma = mapper.Map<CompanyUpdateVM, Firma>(company);

            companyDal.Update(firma);

            return company;
        }

        public CompanyDeleteVM DeleteCompany(CompanyDeleteVM company)
        {
            EFRepo<Firma> companyDal = new EFRepo<Firma>(new GreenHouseContext());

            MyEntityMapper<CompanyDeleteVM, Firma> mapper = new MyEntityMapper<CompanyDeleteVM, Firma>();
            Firma firma = mapper.Map<CompanyDeleteVM, Firma>(company);

            companyDal.SoftDelete(firma);

            return company;
        }
    }
}
