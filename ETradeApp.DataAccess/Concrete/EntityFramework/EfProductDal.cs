using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ETradeApp.DataAccess.Abstract;
using ETradeApp.Entities.Concrete;

namespace ETradeApp.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product,ETradeContext>, IProductDal
    {
    }
}
