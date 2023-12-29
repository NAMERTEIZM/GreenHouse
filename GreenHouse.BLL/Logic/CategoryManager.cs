using GreenHouse.Core;
using GreenHouse.DAL.LogicsDAL;
using GreenHouse.VM.Category;
using GreenHouse.VM.Product;
using MyEfSample.DAL.Mapper;
using MyEFSample.DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace GreenHouse.BLL.Logic
{
    public class CategoryManager
    {
        CategoryDAL CategoryDAL;
        public CategoryManager()
        {
            CategoryDAL = new CategoryDAL();
        }
        public List<CategorySelectVM> GetCategory()
        {
            return CategoryDAL.GetCategory();
        }

        public CategoryInsertVM AddCategory(CategoryInsertVM categoryInsertVM) 
        {
            return CategoryDAL.AddCategory(categoryInsertVM);
        }

        public CategorySelectVM UpdateCategory(CategorySelectVM categorySelectVM)
        {
            return CategoryDAL.UpdateCategory(categorySelectVM);
        }

        public CategorySelectVM DeleteCategory(CategorySelectVM categorySelectVM)
        {
            return CategoryDAL.DeleteCategory(categorySelectVM);
        }
    }
}
