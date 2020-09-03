using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeDemo
{
    class Loop
    {
        public void read() { 
            Console.WriteLine("Enter the numeric Number:");
            int no = int.Parse(Console.ReadLine());
            if (no == 0)
                return;
            for (int i = 0; i <= 10; ++i)
                Console.WriteLine("{0}*{1}={2}", no, i, no * i);
            Console.ReadLine();
        }
}
}
