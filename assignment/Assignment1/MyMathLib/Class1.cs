using MyMathLib.BasicNS;
using MyMathLib.tempratureNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathLib
{
    namespace BasicNS
    {

        public class BasicCalculator
        {
            public int Add(int x,int y)
            {
                return x + y;
            }
            public int Sub(int x, int y)
            {
                return x - y;
            }
            public int Mult(int x, int y)
            {
                return x * y;
            }
            public int Div(int x, int y)
            {
                return x / y;
            }
        }
    }
    namespace tempratureNS
    {
        public class TempratureConvertor
        {
            public Decimal FarenheitToCelcius(Decimal fahrenheit)
            {
                return ((fahrenheit - 32) * 5 / 9);
            }
            public Decimal CelciusToFarenheit(Decimal celsius)
            {
                return ((celsius * 9 / 5) + 32);
            }
        }

    }

    
}
