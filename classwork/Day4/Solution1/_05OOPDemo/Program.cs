using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05OOPDemo
{
    public interface inter1
    {
        void add(int x, int y);
        void sub(int x, int y);

    }
    public interface inter2
    {
        void mult(int x, int y);
        void div(int x, int y);
    }
    public class InnerClass : inter1, inter2
    {
        public void add(int x, int y)
        {
            Console.WriteLine("Add:"+(x+y).ToString());
        }
        public void sub(int x, int y)
        {
            Console.WriteLine("Sub:" + (x - y).ToString());
        }
        public void div(int x, int y)
        {
            Console.WriteLine("Div:" + (x / y).ToString());
        }

        public void mult(int x, int y)
        {
            Console.WriteLine("Multi:" + (x * y).ToString());
        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            InnerClass inner = new InnerClass();
            inner.add(10, 20);
            inner.sub(20, 10);
            inner.div(40, 10);
            inner.mult(10, 10);
            Console.ReadLine();

        }
    }


}
