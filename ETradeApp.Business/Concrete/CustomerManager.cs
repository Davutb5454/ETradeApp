using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETradeApp.Business.Abstract;
using ETradeApp.Entities.Concrete;
using ETradeApp.DataAccess.Abstract;

namespace ETradeApp.Business.Concrete
{
    public class CustomerManager:ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public List<Customer> ListCustomers()
        {
            return _customerDal.ListEntities();
        }
    }
}
