using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETradeApp.Business.Abstract;
using ETradeApp.Business.Utilities;
using ETradeApp.Business.ValidationRules.FluentValidation;
using ETradeApp.DataAccess.Abstract;
using ETradeApp.DataAccess.Concrete;
using ETradeApp.DataAccess.Concrete.EntityFramework;
using ETradeApp.Entities.Concrete;

namespace ETradeApp.Business.Concrete
{
    public class ProductManager:IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> ListProducts()
        {
            return _productDal.ListEntities();
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productDal.ListEntities(p => p.CategoryId == categoryId);
        }

        public List<Product> GetProductsByName(string key)
        {
            return _productDal.ListEntities(p => p.Name.ToLower().Contains(key.ToLower()));
        }

        public void Add(Product product)
        {
            ValidationTool.Validate(new ProductValidator(),product);
            _productDal.AddProduct(product);
        }

        public void Update(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.UpdateProduct(product);
        }

        public void Delete(Product product)
        {
            _productDal.DeleteProduct(product);
        }
    }
}