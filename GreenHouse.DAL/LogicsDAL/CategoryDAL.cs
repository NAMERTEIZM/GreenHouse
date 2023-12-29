using GreenHouse.Core;
using GreenHouse.VM.Category;
using MyEFSample.DAL.Concrete;
using MyEfSample.DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace GreenHouse.DAL.LogicsDAL
{
    public class CategoryDAL
    {
        public List<CategorySelectVM> GetCategory()
        {
            EFRepo<UrunKategori> categoryDAL = new EFRepo<UrunKategori>(new GreenHouseContext());

            List<UrunKategori> categories = categoryDAL.SelectAllWithAsNoTracking();

            List<CategorySelectVM> categoryvms = new List<CategorySelectVM>();

            categories.ForEach(x =>
            {
                categoryvms.Add(new CategorySelectVM
                {
                    ID = x.ID,
                    KategoriAdi = x.KategoriAdi,
                    UstKategoriID = x.UstKategoriID,
                    UstKategori = x.UrunKategori2
                });
            });

            return categoryvms;
        }

        public CategoryInsertVM AddCategory(CategoryInsertVM categoryInsertVM)
        {

            using (var scope = new TransactionScope())
            {
                EFRepo<UrunKategori> categoryDAL = new EFRepo<UrunKategori>(new GreenHouseContext());

                MyEntityMapper<CategoryInsertVM, UrunKategori> mapper = new MyEntityMapper<CategoryInsertVM, UrunKategori>();
                //UrunKategori category = mapper.Map<CategoryInsertVM, UrunKategori>(categoryInsertVM);

                UrunKategori category = new UrunKategori { KategoriAdi = categoryInsertVM.KategoriAdi, UstKategoriID = categoryInsertVM.UstKategoriID };

                UrunKategori addedCategory = categoryDAL.Add(category);

                if (categoryInsertVM.UstKategoriID == 1)
                {
                    addedCategory.UstKategoriID = addedCategory.ID;
                }

                categoryDAL.Update(addedCategory);

                scope.Complete();
            }

            return categoryInsertVM;
        }

        public CategorySelectVM UpdateCategory(CategorySelectVM categorySelectVM)
        {
            EFRepo<UrunKategori> categoryDAL = new EFRepo<UrunKategori>(new GreenHouseContext());

            MyEntityMapper<CategorySelectVM, UrunKategori> mapper = new MyEntityMapper<CategorySelectVM, UrunKategori>();
            UrunKategori category = mapper.Map<CategorySelectVM, UrunKategori>(categorySelectVM);

            categoryDAL.Update(category);

            return categorySelectVM;
        }

        public CategorySelectVM DeleteCategory(CategorySelectVM categorySelectVM)
        {
            EFRepo<UrunKategori> categoryDAL = new EFRepo<UrunKategori>(new GreenHouseContext());

            MyEntityMapper<CategorySelectVM, UrunKategori> mapper = new MyEntityMapper<CategorySelectVM, UrunKategori>();
            UrunKategori category = mapper.Map<CategorySelectVM, UrunKategori>(categorySelectVM);

            categoryDAL.SoftDelete(category);

            return categorySelectVM;
        }
    }
}
