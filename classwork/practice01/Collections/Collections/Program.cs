using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var helicopter = new List<string>();
            helicopter.Add("chinuke");
            helicopter.Add("rafale");
            helicopter.Add("AK1N");
            helicopter.Add("Rajedd");

            foreach(var hel in helicopter)
                Console.WriteLine(hel+" ");
            Console.ReadLine();
        }
    }
}
