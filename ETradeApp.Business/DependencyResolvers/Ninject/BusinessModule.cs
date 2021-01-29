using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETradeApp.Business.Abstract;
using ETradeApp.Business.Concrete;
using ETradeApp.DataAccess.Abstract;
using ETradeApp.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace ETradeApp.Business.DependencyResolvers.Ninject
{
    class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>().InSingletonScope();
            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();
        }
    }
}
