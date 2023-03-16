using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.console
{
    public class DALFactory
    {
        public static DALFactory GetDal()
        {
            return new DALFactory();
        }
    }
}
