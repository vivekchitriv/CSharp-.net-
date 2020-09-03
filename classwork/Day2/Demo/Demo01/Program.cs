using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value of X");
            string data1 = Console.ReadLine();
            int i = Convert.ToInt32(data1);

            Console.WriteLine("Enter value of Y");
            string data2 = Console.ReadLine();
            int j = Convert.ToInt32(data2);

            int sum = i + j;
            Console.WriteLine("Sum is" + sum.ToString());
            Console.ReadLine();
        }
    }
}
