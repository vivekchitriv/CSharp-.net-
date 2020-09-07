using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01OOPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonSelector selector = new PersonSelector();

            Console.WriteLine("Whose details you would like to enter 1: Employee , 2: Customer");
            int choice = Convert.ToInt32(Console.ReadLine());

            //Person p =selector.GetSomePerson(choice);
            Person p = PersonSelector.GetSomePerson(choice);

            Console.WriteLine("You entered:");
            string details = p.GetDetails();

            Console.WriteLine(details);

            Console.ReadLine();
        }
    }

    public class Person
    {
        private int _No;
        private string _Name;
        private string _Address;
        private bool _isWorking;

        public bool IsWorking
        {
            get { return _isWorking; }
            set { _isWorking = value; }
        }


        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int No
        {
            get { return _No; }
            set { _No = value; }
        }

        public virtual string GetDetails()
        {
            return this.No.ToString() + this.Name + this.Address + this.IsWorking.ToString();
        }

    }

    public class Employee : Person
    {
        private string _Dept;

        public string Dept
        {
            get { return _Dept; }
            set { _Dept = value; }
        }

        public override string GetDetails()
        {
            return this.No.ToString() + this.Name + this.Address + this.IsWorking.ToString() + this.Dept;
        }

    }

    public class Customer : Person
    {
        private string _OrderDesc;

        public string OrderDesc
        {
            get { return _OrderDesc; }
            set { _OrderDesc = value; }
        }
        public override string GetDetails()
        {
            return this.No.ToString() + this.Name + this.Address + this.IsWorking.ToString() + this.OrderDesc;
        }
    }

    public class PersonSelector                   //Factory Class
    {
        public static Person GetSomePerson(int choice)  //Factory Method
        {
            if (choice == 1)
            {
                Employee e = new Employee();

                Console.WriteLine("Enter No");
                e.No = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Name");
                e.Name = Console.ReadLine();

                Console.WriteLine("Enter Address");
                e.Address = Console.ReadLine();

                Console.WriteLine("You are working! true / false?");
                e.IsWorking = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Enter Department");
                e.Dept = Console.ReadLine();

                return e;
            }
            else
            {
                Customer c = new Customer();

                Console.WriteLine("Enter No");
                c.No = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Name");
                c.Name = Console.ReadLine();

                Console.WriteLine("Enter Address");
                c.Address = Console.ReadLine();

                Console.WriteLine("You are working! true / false?");
                c.IsWorking = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Enter Order Desc");
                c.OrderDesc = Console.ReadLine();

                return c;
            }
        }
    }
}
