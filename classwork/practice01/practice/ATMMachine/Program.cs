using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMMachine
{
    class Customer
    {
        readonly int custid;
        double bal;
        static int count = 0;
        public Customer ( int custid )
        {
            count += 1;
            this.custid = custid;
            this.bal = 50000.20;
        }

        public double findBalance ( )
        {
            return bal;
        }
        public void deposite ( double amt )
        {
            bal = bal + amt;
        }
        public void withdraw ( double amt )
        {
            bal -= amt;
        }
        

    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer(101);
            double amt = c1.findBalance();
            Console.WriteLine("Balance is :: " + amt.ToString());
            c1.deposite(1000);
            double amt1 = c1.findBalance();
            Console.WriteLine("Balance is :: " + amt1.ToString());
            Customer c2 = new Customer(102);
            c1.withdraw(500);
            double amt2 = c1.findBalance();
            Console.WriteLine("Balance is :: " + amt2.ToString());
            Console.ReadLine();
        }
    }
}

