using GreenHouse.Core;
using GreenHouse.VM.Page;
using MyEFSample.DAL.Concrete;
using MyEfSample.DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.DAL.LogicsDAL
{
    public class PageDAL
    {
        public List<PageSelectVM> GetPage()
        {
            EFRepo<Sayfa> pageDAL = new EFRepo<Sayfa>(new GreenHouseContext());

            List<PageSelectVM> pagevm = new List<PageSelectVM>();

            return pageDAL.SelectAll().Select(a => new PageSelectVM()
            {
                ID = a.ID,
                SayfaAdi = a.SayfaAdi,
            }).ToList();

        }

        public PageSelectVM AddPage(PageSelectVM pageSelectVM)
        {

            EFRepo<Sayfa> pageDAL = new EFRepo<Sayfa>(new GreenHouseContext());

            MyEntityMapper<PageSelectVM, Sayfa> mapper = new MyEntityMapper<PageSelectVM, Sayfa>();
            Sayfa page = mapper.Map<PageSelectVM, Sayfa>(pageSelectVM);
            pageDAL.Add(page);
            return pageSelectVM;
        }
        public PageSelectVM UpdatePage(PageSelectVM pageSelectVM)
        {

            EFRepo<Sayfa> pageDAL = new EFRepo<Sayfa>(new GreenHouseContext());

            MyEntityMapper<PageSelectVM, Sayfa> mapper = new MyEntityMapper<PageSelectVM, Sayfa>();
            Sayfa page = mapper.Map<PageSelectVM, Sayfa>(pageSelectVM);
            pageDAL.Update(page);
            return pageSelectVM;
        }
        public PageSelectVM DeletePage(PageSelectVM pageSelectVM)
        {

            EFRepo<Sayfa> pageDAL = new EFRepo<Sayfa>(new GreenHouseContext());

            MyEntityMapper<PageSelectVM, Sayfa> mapper = new MyEntityMapper<PageSelectVM, Sayfa>();
            Sayfa page = mapper.Map<PageSelectVM, Sayfa>(pageSelectVM);
            pageDAL.HardDelete(page);
            return pageSelectVM;
        }
    }
}
