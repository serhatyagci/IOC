﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.console
{
    public class DataAccessLayer :IDataAccessLayer
    {
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product{Id=1, Name="Kalem", Price=100,Stock=200},
                new Product{Id=2, Name="Kalem2", Price=100,Stock=200},
                new Product{Id=3, Name="Kalem3", Price=100,Stock=200},
                new Product{Id=4, Name="Kalem4", Price=100,Stock=200}
            };
        }
    }
}
