using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Maths obj = new Maths();
            int x = 100;
            int y = 200;
            Console.WriteLine(string.Format("Before Swap x={0},y={1}", x, y));
            obj.Swap<int>(ref x, ref y);
            Console.WriteLine(string.Format("After Swap x={0},y={1}", x, y));
            //Maths obj2 = new Maths();
            string s1 = "hello";
            string s2 = "world";

            Console.WriteLine(string.Format("Before Swap x={0},y={1}", s1, s2));
            obj.Swap<string>(ref s1, ref s2);
            Console.WriteLine(string.Format("After Swap x={0},y={1}", s1, s2));

            int result = obj.Add(10, 20);
            Console.WriteLine(result);



        }
    }
    public class Maths
    {
        public void Swap<T>(ref T x, ref T y)
        {
            T z;
            z = x;
            x = y;
            y = z;
        }
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Sub(int x, int y)
        {
            return x - y;
        }
    }
}
