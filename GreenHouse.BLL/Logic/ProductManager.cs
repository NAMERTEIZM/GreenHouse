using GreenHouse.Core;
using GreenHouse.VM.Product;
using GreenHouse.VM;
using MyEFSample.DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Runtime.Remoting.Contexts;
using MyEfSample.DAL.Mapper;
using AutoMapper;
using GreenHouse.VM.Category;
using GreenHouse.VM.Picture;
using GreenHouse.VM.Company;
using GreenHouse.VM.ProductCompany;
using GreenHouse.VM.ProductIngredient;
using GreenHouse.VM.User;
using GreenHouse.ExceptionHandling;
using GreenHouse.DAL.LogicsDAL;

namespace GreenHouse.BLL.Product
{
    public class ProductManager
    {
        ProductDAL ProductDAL;

        public ProductManager()
        {
            ProductDAL = new ProductDAL();
        }

        // Ürünün bileşenlerini ve bileşenin risk seviyesini döndürür
        public List<IngredientSelectVM> GetIngredientsByProduct(ProductWithIngreadientsVM p)
        {
            return ProductDAL.GetIngredientsByProduct(p);
        }

        public List<ProductSelectVM> GetProducts()
        {
            return ProductDAL.GetProducts();
        }

        public ProductInsertVM UpdateProduct(ProductInsertVM productUpdateVM)
        {
            return ProductDAL.UpdateProduct(productUpdateVM);
        }

        public ProductInsertVM DeleteProduct(ProductInsertVM productUpdateVM)
        {
            return ProductDAL.DeleteProduct(productUpdateVM);
        }

        public ProductInsertVM AddProducts(ProductInsertVM productInsertVM)
        {
            return ProductDAL.AddProducts(productInsertVM);
        }

        public ProductUserInsertVM AddProductsUser(ProductUserInsertVM productUserInsertVM, UserDetailVM userDetailVM)
        {
            return ProductDAL.AddProductsUser(productUserInsertVM, userDetailVM);
        }

        public List<ProductSelectVM> GetProductsFilter(string nameOrBarcode, int categoryId)
        {
            return ProductDAL.GetProductsFilter(nameOrBarcode, categoryId);
        }

        public Urun GetProductByID(Guid productID)
        {
            return ProductDAL.GetProductByID(productID);
        }

        public List<ProductApproveSelectVM> GetProductsApprove()
        {
            return ProductDAL.GetProductsApprove();
        }

        public bool UpdateProductApproveStatus(Guid productID)
        {
            return ProductDAL.UpdateProductApproveStatus(productID);
        }

        public List<ProductUserAddedVM> GetProductsByUserAdded(Guid userRolID)
        {
            return ProductDAL.GetProductsByUserAdded(userRolID);
        }

        public ProductSelectVM GetProductDetail(Guid productID)
        {
            return ProductDAL.GetProductDetail(productID);
        }

        public bool IsFavorite(Guid ProductId, Guid userRoleID, Guid ListID)
        {
            return ProductDAL.IsFavorite(ProductId, userRoleID, ListID);
        }
    }
}
