using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETradeApp.DataAccess.Abstract;
using ETradeApp.Entities.Concrete;

namespace ETradeApp.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category,ETradeContext>,ICategoryDal
    {
    }
}
