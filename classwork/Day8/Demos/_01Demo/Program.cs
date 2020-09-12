using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Demo
{
    delegate int MyDelegate(int x, int y);
    class Program
    {

        static void Main(string[] args)
        {
            #region Direct Call to Method
            /*
            int result = Add(10, 20);
            Console.WriteLine(result);
            Console.ReadLine(); 
            */
            #endregion

        }
        static int Add(int x,int y)
        {
            return x + y;
        }
    }
}
