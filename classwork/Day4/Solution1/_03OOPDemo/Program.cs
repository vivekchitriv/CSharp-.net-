using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03OOPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Department depart = new Department();
            depart.DeptNo = 100;
            depart.DeptName = "Finance";
            

            Employee emp = new Employee();
            emp.EDepartment = depart;
            emp.No = 101;
            emp.Name = "Vivek"; 


            emp.PrintDetails();
            Console.ReadLine();


        }
    }
    public class Employee
    {
        private int _No;
        private string _Name;
        private Department _EDepartment;

        public Department EDepartment
        {
            get { return _EDepartment; }
            set { _EDepartment = value; }
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

        public void PrintDetails ( )
        {
            Console.WriteLine("No:"+No.ToString());
            Console.WriteLine("Name:"+Name);
            Console.WriteLine("Dept No:"+EDepartment.DeptNo.ToString());
            Console.WriteLine("Dept Name:"+EDepartment.DeptName);
            Console.WriteLine("Dept Address"+EDepartment.DAddress);
            
        }
    }

    public class Department
    {
        private int _DeptNo;
        private string _DeptName;
        private Address _DAddress;


        
        
        public Address DAddress
        {
            get { return _DAddress; }
            set { _DAddress = value; }
        }

        public string DeptName
        {
            get { return _DeptName; }
            set { _DeptName = value; }
        }

        public int DeptNo
        {
            get { return _DeptNo; }
            set { _DeptNo = value; }
        }

    }

    public class Address
    {
        private string _DeptAddress;

        public string DeptAddress
        {
            get { return _DeptAddress; }
            set { _DeptAddress = value; }
        }

    }
}
