using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _04DemoAttributes
{

    class TestAttribute : Attribute { }
    
    [TestAttribute]
   public class MyTestSuite
    {

    }
    public class Program
    {
        static void Main(string[] args)
        {
            foreach(Type t in Assembly.GetExecutingAssembly().GetTypes())
                    foreach(Attribute a in t.GetCustomAttributes())
                        if(a is TestAttribute)
                            Console.WriteLine(t.Name+"is a test suites!");
            Console.ReadLine();                
        }
    }
}
