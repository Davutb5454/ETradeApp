using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETradeApp.Entities.Abstract;

namespace ETradeApp.Entities.Concrete
{
    public class Product:IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string  Name { get; set; }
        public decimal UnitPrice { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
    }
}
