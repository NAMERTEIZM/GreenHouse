using GreenHouse.Core;
using GreenHouse.VM.Ingredient;
using GreenHouse.VM.Product;
using GreenHouse.VM;
using MyEFSample.DAL.Concrete;
using MyEfSample.DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenHouse.VM.User;

namespace GreenHouse.DAL.LogicsDAL
{
    public class IngredientDAL
    {
        public List<IngredientSelectVM> GetIngredient()
        {
            EFRepo<Bilesen> ingredientDAL = new EFRepo<Bilesen>(new GreenHouseContext());
            List<Bilesen> ingredient = ingredientDAL.SelectAllWithAsNoTracking();

            return ingredient.Select(x => new IngredientSelectVM()
            {
                ID = x.ID,
                Adi = x.Adi,
                Aciklama = x.Aciklama,
                RiskTur = x.Risk.RiskTur
            }).ToList();
        }

        public List<IngredientSelectVM> GetIngredientWithoutUserBlackListItems(UserDetailVM userDetailVM)
        {
            UserDAL userDAL = new UserDAL();
            EFRepo<Bilesen> ingredientDAL = new EFRepo<Bilesen>(new GreenHouseContext());
            List<Bilesen> ingredient = ingredientDAL.SelectAllWithAsNoTracking();

            List<UserListItemSelectVM> blackList = userDAL.GetUserBlackListItems(userDetailVM);

            List<IngredientSelectVM> ingredientSelectVMs = ingredient
                .Where(item => !blackList.Any(blackListItem => blackListItem.IcerikID == item.ID))
                .Select(item => new IngredientSelectVM
                {
                    ID = item.ID,
                    RiskTur = item.Risk.RiskTur,
                    Aciklama = item.Aciklama,
                    Adi = item.Adi
                })
                .ToList();

            return ingredientSelectVMs;
        }

        public List<IngredientVM> GetIngredientsByProduct(ProductWithIngreadientsVM p)
        {
            EFRepo<Bilesen> ingredientDAL = new EFRepo<Bilesen>(new GreenHouseContext());
            List<Bilesen> ingredient = ingredientDAL.SelectAll();

            return ingredient.Select(x => new IngredientVM()
            {
                ID = x.ID,
                Adi = x.Adi,
                Aciklama = x.Aciklama,
                Risk = x.Risk
            }).ToList();
        }

        public IngredientInsertVM AddIngredient(IngredientInsertVM ingredientVM)
        {
            EFRepo<Bilesen> ingredientDAL = new EFRepo<Bilesen>(new GreenHouseContext());
            ingredientVM.ID = Guid.NewGuid();
            MyEntityMapper<IngredientInsertVM, Bilesen> mapper = new MyEntityMapper<IngredientInsertVM, Bilesen>();
            Bilesen ingredient = mapper.Map<IngredientInsertVM, Bilesen>(ingredientVM);
            return mapper.Map<Bilesen, IngredientInsertVM>(ingredientDAL.Add(ingredient));
        }
        public IngredientDeleteVM DeleteIngredient(IngredientDeleteVM ingredientVM)
        {
            try
            {
                EFRepo<Bilesen> ingredientDAL = new EFRepo<Bilesen>(new GreenHouseContext());
                MyEntityMapper<IngredientDeleteVM, Bilesen> mapper = new MyEntityMapper<IngredientDeleteVM, Bilesen>();
                Bilesen ingredient = mapper.Map<IngredientDeleteVM, Bilesen>(ingredientVM);
                return mapper.Map<Bilesen, IngredientDeleteVM>(ingredientDAL.HardDelete(ingredient));
            }
            catch (Exception ex)
            {

                return null;
            }

        }

        public IngredientUpdateVM UpdateIngredient(IngredientUpdateVM ingredientVM)
        {
            EFRepo<Bilesen> ingredientDAL = new EFRepo<Bilesen>(new GreenHouseContext());
            MyEntityMapper<IngredientUpdateVM, Bilesen> mapper = new MyEntityMapper<IngredientUpdateVM, Bilesen>();
            Bilesen ingredient = mapper.Map<IngredientUpdateVM, Bilesen>(ingredientVM);
            return mapper.Map<Bilesen, IngredientUpdateVM>(ingredientDAL.Update(ingredient));
        }

        public Bilesen GetIngredientByID(Guid ingredientID)
        {
            EFRepo<Bilesen> ingredientDAL = new EFRepo<Bilesen>(new GreenHouseContext());
            Bilesen ingredient = ingredientDAL.SelectAll(x => x.ID == ingredientID).SingleOrDefault();

            return ingredient;
        }
    }
}
