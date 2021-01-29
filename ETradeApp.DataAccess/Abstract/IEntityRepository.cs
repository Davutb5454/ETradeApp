using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ETradeApp.Entities.Abstract;

namespace ETradeApp.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> ListEntities(Expression<Func<T,bool>> filter=null);
        void AddProduct(T entity);
        void UpdateProduct(T entity);
        void DeleteProduct(T entity);
    }
}
