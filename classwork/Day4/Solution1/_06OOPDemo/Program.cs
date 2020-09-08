using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Strategy Design Pattern
namespace _06OOPDemo
{

    class Program
    {
        static void Main(string[] args)
        {
            Flipkart fpkt = new Flipkart();
            string result = fpkt.shopping(new string[] {"Perfume", "shirt","pant" },new double[] { 200,1522,1200});
            //fpkt.shopping("Shirt", 1200);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }

    public interface Courier
    {
        string deliver(int oid); 
    }

    public class BlueDart : Courier
    {
        public BlueDart()
        {
            Console.WriteLine("BlueDart()::0 - param constructor");
        }
        public string deliver(int oid)
        {
            return "Bluedart Courier will deliver with order id"+oid.ToString()+"with product";
        }
    }
    public class FirstFlight : Courier
    {

         public FirstFlight()
        {
            Console.WriteLine("FirstFlight() :: 0 -param constructor");
        }
        public string deliver(int oid)
        {
            return "FirstFlight Courier will deliver with order id" + oid.ToString() + "with product";
        }


    }

    public class DTDC : Courier
    {

        public DTDC()
        {
            Console.WriteLine("DTDC()::0 - param constructor");
        }
        public string deliver(int oid)
        {
            return "DTDC Courier will deliver with order id" + oid.ToString() + "with product";
        }
    }

    public class Flipkart
    {
       

        private Courier _courier;

        public Courier courier
        {
            get { return _courier; }
            set { _courier = value; }
                    
        }

        public Flipkart()
        {
            Console.WriteLine("Flipkart()::0 -param constructor");
        }

        public Flipkart(Courier courier)
        {
            Console.WriteLine("Flipkart()::1 -param constructor");
            this.courier = courier;
        }

        public string shopping(string[] items,double[] prices)
        {
            double billAmt = 0.0f;
            int oid = 0;
            string msg = null;
            Random rad = null;
            
            foreach (double p in prices)
                billAmt += p;
            //generate order id randomly as random number
            rad = new Random();
            oid = rad.Next(10000);
            DTDC courier = new DTDC();
            msg = courier.deliver(oid);

            //Console.WriteLine(items.ToArray() + "Are purchase having prices" + prices.ToArray().ToString() + " with  bill Amt " + billAmt + "..." + msg);
            return   string.Join(" ,",items)+ "Are purchase having prices" + prices.ToArray().ToString() + " with  bill Amt " + billAmt + "..." + msg;
        }


    }
}
