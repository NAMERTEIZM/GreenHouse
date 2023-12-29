using GreenHouse.VM;
using MyEFSample.DAL.Concrete;
using MyEfSample.DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using GreenHouse.Core;
using GreenHouse.VM.Product;
using GreenHouse.VM.Ingredient;
using GreenHouse.DAL.LogicsDAL;
using GreenHouse.VM.User;

namespace GreenHouse.BLL.Ingredient
{
    public class IngredientManager
    {
        IngredientDAL IngredientDAL;

        public IngredientManager()
        {
            IngredientDAL = new IngredientDAL();
        }

        public List<IngredientSelectVM> GetIngredient()
        {
            return IngredientDAL.GetIngredient();
        }

        public List<IngredientVM> GetIngredientsByProduct(ProductWithIngreadientsVM p)
        {
            return IngredientDAL.GetIngredientsByProduct(p);
        }

        public List<IngredientSelectVM> GetIngredientWithoutUserBlackListItems(UserDetailVM userDetailVM)
        {
            return IngredientDAL.GetIngredientWithoutUserBlackListItems(userDetailVM);
        }

        public IngredientInsertVM AddIngredient(IngredientInsertVM ingredientVM)
        {
            return IngredientDAL.AddIngredient(ingredientVM);
        }
        public IngredientDeleteVM DeleteIngredient(IngredientDeleteVM ingredientVM)
        {
            return IngredientDAL.DeleteIngredient(ingredientVM);
        }

        public IngredientUpdateVM UpdateIngredient(IngredientUpdateVM ingredientVM)
        {
            return IngredientDAL.UpdateIngredient(ingredientVM);
        }
    }
}
