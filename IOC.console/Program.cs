using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BL bl = new BL();

            bl.GetProducts().ForEach(x=> 
            {
                Console.WriteLine($"{x.Id}-{x.Name}-{x.Price}-{x.Stock}");
            });

            Console.ReadLine();
        }
    }
}
