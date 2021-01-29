using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETradeApp.Entities.Concrete;

namespace ETradeApp.Business.Abstract
{
    public interface IProductService
    {
        List<Product> ListProducts();
        List<Product> GetProductsByCategory(int categoryId);
        List<Product> GetProductsByName(string key);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
