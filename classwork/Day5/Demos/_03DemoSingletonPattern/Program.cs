using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03DemoSingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var chocoEggs = ChocolateBoiler.GetInstance();
                chocoEggs.Fill();
                chocoEggs.Boil();
                chocoEggs.Drain();
                Console.ReadLine();
            }
            catch(Exception)
            {
                Console.WriteLine("OOPS");
                Console.ReadLine();
            }


        }
    }
}
