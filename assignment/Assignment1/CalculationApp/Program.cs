using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMathLib.BasicNS;
using MyMathLib.tempratureNS;
namespace CalculationApp
{
    public class MenuDrivenProgram
    {
        static void Main(string[] args)
        {

            int i = 0, j = 0;
            string a = null, b = null; ;
            int ch = 0;
            BasicCalculator calculator = null;
            //className refernce = null;
            TempratureConvertor convertor = null;
            
             convertor = new TempratureConvertor();
             calculator = new BasicCalculator();
            
            do
            {
                Console.WriteLine("Menu Driven Program\n");
                Console.WriteLine("0. EXIT\n");
                Console.WriteLine("1. Add\n");
                Console.WriteLine("2. Sub\n");
                Console.WriteLine("3. Mult\n");
                Console.WriteLine("4. Div\n");
                Console.WriteLine("5. fahrenheit to celsius\n");
                Console.WriteLine("6. celsius to fahrenheit \n");
                Console.WriteLine("Enter your choice:");
                string choice = Console.ReadLine();
                ch = Convert.ToInt32(choice);

                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter the value of a:");
                        a = Console.ReadLine();
                        i = Convert.ToInt32(a);


                        Console.WriteLine("Enter the value of b:");
                        b = Console.ReadLine();
                        j = Convert.ToInt32(b);
                        int res = calculator.Add(i, j);
                        Console.WriteLine("ADDITION :" + res.ToString());
                        break;
                    case 2:
                        Console.WriteLine("Enter the value of a:");
                        a = Console.ReadLine();
                        i = Convert.ToInt32(a);


                        Console.WriteLine("Enter the value of b:");
                        b = Console.ReadLine();
                        j = Convert.ToInt32(b);
                        int res1 = calculator.Sub(i, j);
                        Console.WriteLine("SUBSTRACTION :" + res1.ToString());
                        break;
                    case 3:
                        Console.WriteLine("Enter the value of a:");
                        a = Console.ReadLine();
                        i = Convert.ToInt32(a);


                        Console.WriteLine("Enter the value of b:");
                        b = Console.ReadLine();
                        j = Convert.ToInt32(b);
                        int res2 = calculator.Mult(i, j);
                        Console.WriteLine("MULTIPLICATION :" + res2.ToString());
                        break;
                    case 4:
                        Console.WriteLine("Enter the value of a:");
                        a = Console.ReadLine();
                        i = Convert.ToInt32(a);


                        Console.WriteLine("Enter the value of b:");
                        b = Console.ReadLine();
                        j = Convert.ToInt32(b);
                        int res3 = calculator.Add(i, j);
                        Console.WriteLine("DIVISION :" + res3.ToString());
                        break;
                    case 5:
                        
                        Console.WriteLine("Enter the value of fahrenheit :");
                        string fahrenheit = Console.ReadLine();
                        decimal far = Convert.ToDecimal(fahrenheit);
                        Decimal res4 = convertor.FarenheitToCelcius(far);
                        Console.WriteLine("Celcius :" + res4.ToString());
                        break;
                    case 6:

                        Console.WriteLine("Enter the value of celsius  :");
                        string celsius = Console.ReadLine();
                        decimal cels = Convert.ToDecimal(celsius);
                        Decimal res5 = convertor.CelciusToFarenheit(cels);
                        Console.WriteLine("Celcius :" + res5.ToString());
                        break;
                    default:
                        Console.Write("Input correct option\n");
                        break;
                }
            } while (ch != 0);


        }
    }
}
