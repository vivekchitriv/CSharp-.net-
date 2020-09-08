using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Product_FIle_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            //product.writeDetails();
            product.ReadDetails();
            Console.ReadLine();
        }
    }
}
