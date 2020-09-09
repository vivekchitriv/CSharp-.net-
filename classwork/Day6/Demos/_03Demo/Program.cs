using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _03Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Multiple Employee data 

            /*
            Employee e1 = new Employee("Pune", "Mahesh", 101);
            Employee e2 = new Employee("Nagpur", "Sourabh", 102);
            Employee e3 = new Employee("Mumbai", "Akash", 103);
            Employee e4 = new Employee("Karad", "Rahul", 104);

            ArrayList arr = new ArrayList();
            arr.Add("Vivek");
            arr.Add(100);
            arr.Add(e1);
            arr.Add(200);
            arr.Add(e2);
            arr.Add(e4);*/

            #endregion

            #region Add data using serialize , ArrayList
            /*ArrayList arr = new ArrayList();

            while(true)
            {
                Console.WriteLine("which object data : 1. Employee 2. Book");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Employee emp = new Employee();

                        Console.WriteLine("Enter Emp No");
                        emp.No = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Emp Name");
                        emp.Name = Console.ReadLine();

                        Console.WriteLine("Enter Emp Address");
                        emp.Address = Console.ReadLine();

                        arr.Add(emp);
                        break;
                    case 2:
                        Book b = new Book();

                        Console.WriteLine("Enter ISBN ");
                        b.ISBN = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Title ");
                        b.title = Console.ReadLine();

                        arr.Add(b);
                        break;
                    default:
                        Console.WriteLine("Invaid choice  !");
                        break;

                }
                Console.WriteLine("Do you want any more object to store into file 1. Yes / 2.  ");
                int continu= Convert.ToInt32(Console.ReadLine());
                if(continu == 2)
                {
                    break;
                }

            }
            
            FileStream fs = new FileStream(@"D:\KDAC_Online_COurse\msnet_vivek_36441\classwork\Day6\Demos\_03Demo\data.txt", 
                FileMode.OpenOrCreate, FileAccess.Write);

            BinaryFormatter writer = new BinaryFormatter();
            writer.Serialize(fs, arr);
            writer = null;
            fs.Close();*/

            #endregion

            #region Read multiple data from file using deserialization

            FileStream fs = new FileStream(@"D:\KDAC_Online_COurse\msnet_vivek_36441\classwork\Day6\Demos\_03Demo\data.txt",
                FileMode.Open,FileAccess.Read);

                BinaryFormatter reader = new BinaryFormatter();
                ArrayList arr = (ArrayList)reader.Deserialize(fs);

            foreach (Object obj in arr)
            {
                if(obj is int)
                {
                    int j = Convert.ToInt32(obj);
                    Console.WriteLine(j);
                }
                else if(obj is string)
                {
                    string s = obj.ToString();
                    Console.WriteLine(s);
                }
                else if(obj is Employee)
                {
                    Employee e = (Employee)obj;
                    Console.WriteLine(e.Name);
                }
                else if( obj is Book)
                {
                    Book b = (Book)obj;
                    Console.WriteLine(" welcome with title :"+b.title);
                }
                else
                {
                    Console.WriteLine("Unknow Data!");
                }
            }
            Console.ReadLine();

            #endregion
        }
    }

    [Serializable]
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

        public Employee()
        {
            Address = "";
            Name = "";
            No = 0;
        }
        public Employee(string address, string name, int no)
        {
            Address = address;
            Name = name;
            No = no;
        }
    }
    [Serializable]
    public class Book
    {
        private int _ISBN;

        private string _title;

        public string title
        {
            get { return _title; }
            set { _title = value; }
        }

        public int ISBN
        {
            get { return _ISBN; }
            set { _ISBN = value; }
        }

        /*public Book(int iSBN, string title)
        {
            _ISBN = iSBN;
            _title = title;
        }*/
    }
}
