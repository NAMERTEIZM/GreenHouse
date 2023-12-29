using GreenHouse.Core;
using GreenHouse.VM.Risks;
using MyEFSample.DAL.Concrete;
using MyEfSample.DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenHouse.VM.Page;
using GreenHouse.DAL.LogicsDAL;

namespace GreenHouse.BLL.Logic
{
    public class PageManager
    {
        PageDAL PageDAL;

        public PageManager()
        {
            PageDAL = new PageDAL();
        }

        public List<PageSelectVM> GetPage()
        {
            return PageDAL.GetPage();

        }

        public PageSelectVM AddPage(PageSelectVM pageSelectVM)
        {
            return PageDAL.AddPage(pageSelectVM);         
        }

        public PageSelectVM UpdatePage(PageSelectVM pageSelectVM)
        {
            return PageDAL.UpdatePage(pageSelectVM);
        }

        public PageSelectVM DeletePage(PageSelectVM pageSelectVM)
        {
            return PageDAL.DeletePage(pageSelectVM);
        }
    }
}
