using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Maths obj = new Maths();
            int x = 100;
            int y = 200;
            /*Console.WriteLine( "Before Swap" );
            string str = "Before Swap x={0},y={1}";
            string finalStringtobeprinted = string.Format(str, x, y);*/
            Console.WriteLine(string.Format("Before Swap x={0},y={1}", x, y));
            obj.Swap(ref x, ref y);
            Console.WriteLine(string.Format("After Swap x={0},y={1}", x, y));
        }
    }
    public class Maths
    {
        public void Swap(ref int x, ref int y)
        {
            int z;
            z = x;
            x = y;
            y = z;
        }
        public int Add( int x ,int y)
        {
            return x + y;
        }
        public int Sub(int x, int y)
        {
            return x - y;
        }
    }

}
