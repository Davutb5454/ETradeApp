using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETradeApp.Entities.Concrete;

namespace ETradeApp.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
    }
}
