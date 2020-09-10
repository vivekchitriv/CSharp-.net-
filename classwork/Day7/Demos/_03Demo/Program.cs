using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Demo
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Maths<T>
    {

        public void Swap(ref T x,ref T y)
        {
            T z;
            z = x;
            x = y;
            y = z;
        }
    }
}
