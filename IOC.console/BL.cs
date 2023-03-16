using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.console
{
    public class BL
    {
        private DataAccessLayer _dal { get; set; }
        public BL()
        {
            _dal= new DataAccessLayer();
        }
        public List<Product> GetProducts()
        {
            return _dal.GetProducts();
        }
    }
}
