using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day02_01
{
    class Program
    {
        //method without any return and input
        public void test1()
        {
            int x = 5;
            for(int i = 0 ; i <= 10; ++ i)
            {
                Console.WriteLine("{0}*{1}={2}", x, i, x * i);

            }

        }

        //methodwith input and without any return
        public void test2(int x, int y)
        {

            for(int i=0;i<=x;i++)
            {
                Console.WriteLine("{0}*{1}={2}", i, x, i * x);
            }
        }
        public string test3()
        {
            string str = "welcome to kdac for .net module";
            str = str.ToUpper();
            return str;
        }
        public string test4(string str)
        {
            str = str.ToUpper();
            return str;
        }
        static void Main(string[] args)
        {
            Program p = null;
            p = new Program();
            Console.WriteLine("------------------------------------------------");
            p.test1();
            Console.WriteLine("------------------------------------------------");
            p.test2(6, 12);
            Console.WriteLine("------------------------------------------------");
            string str = p.test3();
            Console.WriteLine(str);
            Console.ReadLine();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(p.test4("Hellow World"));
            Console.ReadLine();

        }
    }
}
