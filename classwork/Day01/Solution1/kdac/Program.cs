using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kdac
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Enter value of X:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of Y:");
            y = int.Parse(Console.ReadLine());

            z = x + y;
            Console.WriteLine("the Sum of {0} and {1} is {2}:",x, y, z);
            Console.ReadLine();
        }
    }
}

