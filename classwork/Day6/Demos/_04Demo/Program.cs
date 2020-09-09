using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;

namespace _04Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Multiple Employee data 


            #endregion


            
            while (true)
            {
                
                Console.WriteLine("You want to Write and read data...1 .Write into file 2. read from file");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch(ch)
                {
                    case 1:
                        #region Add data using serialize , ArrayList
                        ArrayList arr = new ArrayList();
                        while (true)
                        {
                            Console.WriteLine("which object data : 1. Employee 2. Book");
                            int choice = Convert.ToInt32(Console.ReadLine());
                            switch (choice)
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
                            Console.WriteLine("Do you want any more object to store into file 1. Yes / 2.No  ");
                            int continu = Convert.ToInt32(Console.ReadLine());
                            if (continu == 2)
                            {
                                break;
                            }

                        }
                        FileStream fs = new FileStream(@"D:\KDAC_Online_COurse\msnet_vivek_36441\classwork\Day6\Demos\_04Demo\data.txt",
                        FileMode.OpenOrCreate, FileAccess.Write);

                        BinaryFormatter writer = new BinaryFormatter();
                        writer.Serialize(fs, arr);
                        writer = null;
                        fs.Close();
                        break;
                    #endregion
                    case 2:
                        #region Read multiple data from file using deserialization

                        FileStream fs1 = new FileStream(@"D:\KDAC_Online_COurse\msnet_vivek_36441\classwork\Day6\Demos\_04Demo\data.txt",
                            FileMode.Open, FileAccess.Read);

                        BinaryFormatter reader = new BinaryFormatter();
                        ArrayList arr1 = (ArrayList)reader.Deserialize(fs1);

                        foreach (Object obj in arr1)
                        {
                            if (obj is int)
                            {
                                int j = Convert.ToInt32(obj);
                                Console.WriteLine(j);
                            }
                            else if (obj is string)
                            {
                                string s = obj.ToString();
                                Console.WriteLine(s);
                            }
                            else if (obj is Employee)
                            {
                                Employee e = (Employee)obj;
                                Console.WriteLine(e.Name);
                            }
                            else if (obj is Book)
                            {
                                Book b = (Book)obj;
                                Console.WriteLine(" welcome with title :" + b.title);
                            }
                            else
                            {
                                Console.WriteLine("Unknow Data!");
                            }
                        }
                        Console.ReadLine();
                        #endregion
                        break;
                    default:
                        Console.WriteLine("Invalid Choice..");
                        break;

                }
                Console.WriteLine("Do you want any read / write data 1. Yes / 2.No  ");
                int continu1 = Convert.ToInt32(Console.ReadLine());
                if (continu1 == 2)
                {
                    break;
                }
            }
            
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

        
    }
}
