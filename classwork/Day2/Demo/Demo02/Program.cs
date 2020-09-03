using MathLib;
using System;
namespace Demo02
{

    class Program
    {

        static void Main(string[] args)
        {
            Maths obj = new Maths();
            while (true)
            {
                Console.WriteLine("Enter Value of X");
                string data1 = Console.ReadLine();
                int i = Convert.ToInt32(data1);

                Console.WriteLine("Enter Value of Y");
                string data2 = Console.ReadLine();
                int j = Convert.ToInt32(data2);

                Console.WriteLine("Enter Your Operation Choice");
                Console.WriteLine("1: Add, 2: Sub, 3: Mult, 4: Div");
                string choice = Console.ReadLine();
                int ch = Convert.ToInt32(choice);

                switch (ch)
                {
                    case 1:

                        int sum = obj.Add(i, j);
                        Console.WriteLine("Sum is " + sum.ToString());
                        break;

                    case 2:
                        int sub = obj.Sub(i, j);
                        Console.WriteLine("Sub is " + sub.ToString());
                        break;

                    case 3:
                        int mult = obj.Mult(i, j);
                        Console.WriteLine("Mult is " + mult.ToString());
                        break;


                    case 4:
                        int div = obj.Div(i, j);
                        Console.WriteLine("Div is " + div.ToString());
                        break;

                    default:
                        Console.WriteLine("Invalid Choice!!");
                        break;
                }

                Console.WriteLine("Hit Enter to Continue Doing Operations...");
                Console.ReadLine();
            }
        }
    }
}
