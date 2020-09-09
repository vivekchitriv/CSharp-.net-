using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Boxing UnBoxing
            //short s = 20; // stack
            //Person p = new Person();
            //p.Name = "Vivek";

            //int i = 100; 
            //Object obj = i ; //Boxing

            //int j =(int) obj;    //UnBoxing
            //int j = Convert.ToInt32(obj);    //UnBoxing
            #endregion

            #region int array
            //int[] arr = new int[3];
            //arr[0] = 100;
            //arr[1] = 200;
            //arr[2] = 300;
            //int i;
            //for ( i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i].ToString());
            //}
            #endregion

            #region Object type array
            //Employee e1 = new Employee(1, "Mahesh", "Hyd");
            //Employee e2 = new Employee(2, "Vivek", "Pune");
            //Employee e3 = new Employee(3, "Shubham", "Sangli");
            //Employee e4 = new Employee(4, "Akshay", "Satara");

            // Employee[] emps = new Employee[4];

            //Employee[] emps = new Employee[4] {e1,e2,e3,e4};
            //Console.WriteLine(emps.Length);

            ////emps[0] = e1;
            ////emps[1] = e2;
            ////emps[2] = e3;
            ////emps[3] = e4;

            ////for (int j = 0; j < emps.Length; j++)
            ////{
            ////    Console.WriteLine(emps[j].No);
            ////    Console.WriteLine(emps[j].Name);
            ////    Console.WriteLine(emps[j].Address);

            ////}
            //foreach(Employee e in emps)
            //{
            //    Console.WriteLine(e.No);
            //    Console.WriteLine(e.Name);
            //    Console.WriteLine(e.Address);
            //}
            //Console.ReadLine();

            #endregion


            #region Itration using forEach loop
            //Employee e1 = new Employee(1, "Mahesh", "Hyd");
            //Employee e2 = new Employee(2, "Vivek", "Pune");
            //Employee e3 = new Employee(3, "Shubham", "Sangli");
            //Employee e4 = new Employee(4, "Akshay", "Satara");


            //object[] arr = new object[] { "abcd", 100, e1, 200, e2, 300, e3, "cdefg",e4};

            //foreach(object obj in arr)
            //{
            //    if(obj is int)
            //    {
            //        int e = Convert.ToInt32(obj);//UnBoxing
            //        Console.WriteLine(e);
            //    }
            //    else if(obj is string)
            //    {
            //        string s = Convert.ToString(obj); //casting
            //        Console.WriteLine(s);
            //    }
            //    else if(obj is Employee)
            //    {
            //        Employee emp = (Employee) obj;//casting
            //        Console.WriteLine(emp.Name);
            //    }
            //    else
            //    {
            //        Console.WriteLine("unKnow Data!");
            //    }
            //}
            //Console.ReadLine();

            #endregion


            #region ArrayList

            //Employee e1 = new Employee(1, "Mahesh", "Hyd");
            //Employee e2 = new Employee(2, "Vivek", "Pune");
            //Employee e3 = new Employee(3, "Shubham", "Sangli");
            //Employee e4 = new Employee(4, "Akshay", "Satara");

            //ArrayList list = new ArrayList();
            //list.Add("LAVASA");
            //list.Add(100);
            //list.Add(e1);
            //list.Add(200);
            //list.Add(e2);
            //list.Add(e3);

            //foreach (object obj in list)
            //{
            //    if (obj is int)
            //    {
            //        int j = Convert.ToInt32(obj);
            //        Console.WriteLine(j);
            //    }
            //    else if (obj is string)
            //    {
            //        string s = obj.ToString();
            //        Console.WriteLine(s);
            //    }
            //    else if (obj is Employee)
            //    {
            //        Employee e = (Employee)obj;
            //        Console.WriteLine(e.Name);
            //    }
            //    else
            //    {
            //        Console.WriteLine("unkown Data!");
            //    }
            //}
            //Console.ReadLine();
            #endregion

            #region HashTable

            //    Employee e1 = new Employee(1, "Mahesh", "Hyd");
            //    Employee e2 = new Employee(2, "Vivek", "Pune");
            //    Employee e3 = new Employee(3, "Shubham", "Sangli");
            //    Employee e4 = new Employee(4, "Akshay", "Satara");

            //    Hashtable arr = new Hashtable();
            //    arr.Add("a", "abcd");
            //    arr.Add("b", 100);
            //    arr.Add("c", e1);
            //    arr.Add("d", 200);
            //    arr.Add("e", e2);
            //    arr.Add("f", e3);

            //    Console.WriteLine("What would you like to search in collection?");
            //    string keyToBeSearched = Console.ReadLine();
            //    object obj = arr[keyToBeSearched];
            //    if (obj != null)
            //    {
            //        if (obj is int)
            //        {
            //            int j = Convert.ToInt32(obj); //Unboxing
            //            Console.WriteLine(j);
            //        }
            //        else if (obj is string)
            //        {

            //            string s = Convert.ToString(obj);  //Casting
            //                                               //s = "pqrs";
            //            Console.WriteLine(s);
            //        }
            //        else if (obj is Employee)
            //        {
            //            Employee e = (Employee)obj;        //Casting
            //            Console.WriteLine(e.Name);
            //        }
            //        else
            //        {
            //            Console.WriteLine("UnKnown Data!");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Specified Key Does not exist!!");
            //    }
            //    Console.ReadLine();
            //}
            #endregion

            #region Again HashTable

            //Employee e1 = new Employee(1, "Mahesh", "Hyd");
            //Employee e2 = new Employee(2, "Vivek", "Pune");
            //Employee e3 = new Employee(3, "Shubham", "Sangli");
            //Employee e4 = new Employee(4, "Akshay", "Satara");
            //Hashtable arr = new Hashtable();
            //arr.Add("a", "abcd");
            //arr.Add("b", 100);
            //arr.Add("c", e1);
            //arr.Add("d", 200);
            //arr.Add("e", e2);
            //arr.Add("f", e3);

            //foreach (object key in arr.Keys)
            //{
            //    Console.WriteLine("Key is : " + key.ToString());

            //    object obj = arr[key];

            //    if (obj is int)
            //    {
            //        int j = Convert.ToInt32(obj); //Unboxing
            //        Console.WriteLine(j);
            //    }
            //    else if (obj is string)
            //    {

            //        string s = Convert.ToString(obj);  //Casting
            //                                           //s = "pqrs";
            //        Console.WriteLine(s);
            //    }
            //    else if (obj is Employee)
            //    {
            //        Employee e = (Employee)obj;        //Casting
            //        Console.WriteLine(e.Name);
            //    }
            //    else
            //    {
            //        Console.WriteLine("UnKnown Data!");
            //    }
            //}
            //Console.ReadLine();
            #endregion

        }

    }

        #region Employee class
        public class Employee
    {
        private int _No;
        private string _Name;
        private string _Address;

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

        public Employee(int no, string name, string address)
        {
            _No = no;
            _Name = name;
            _Address = address;
            
        }
    }
    #endregion

    #region Person class
    public class Person
    {
        public string Name;
    }
    #endregion



}
