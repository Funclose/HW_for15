using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Polimorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Laptop", 1000, 99);
            product.ShowProduct();
            product.MyDiscount(100, 50);
            product.ShowProduct();

        }
    }
}
