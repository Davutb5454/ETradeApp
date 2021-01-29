using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETradeApp.Business.Abstract;
using ETradeApp.DataAccess.Abstract;
using ETradeApp.Entities.Concrete;

namespace ETradeApp.Business.Concrete
{
    public class CategoryManager:ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> ListCategories()
        {
            return _categoryDal.ListEntities();
        }
    }
}
