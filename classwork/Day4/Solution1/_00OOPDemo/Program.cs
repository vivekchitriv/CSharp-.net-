using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00OOPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee p = new Employee();

            Console.WriteLine("Enter No");
            p.No = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name");
            p.Name = Console.ReadLine();

            Console.WriteLine("Enter Address");
            p.Address = Console.ReadLine();

            Console.WriteLine("You are working! true / false?");
            p.IsWorking = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Enter Department");
            p.Dept = Console.ReadLine();


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
}
