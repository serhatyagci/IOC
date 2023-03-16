using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.console
{
    public class BL
    {
        private IDataAccessLayer _dal { get; set; }
        public BL(IDataAccessLayer dal)
        {
            _dal= dal;
        }
        public List<Product> GetProducts()
        {
            return _dal.GetProducts();
        }
    }
}
