using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
///     Generics 
///     Generics. Generic classes have type parameters. Separate classes, each with a different field type in them, can be replaced with a single generic class.
///A generic class introduces a type parameter (often specified as the letter T). This becomes part of the class definition itself.Generic methods can also be designed.
///     1. List<>
///     2. Stack<>
///     3. Queue<>
///     4. Dictionary<>
/// </summary>
namespace _04Demo
{

    class Program
    {
        static void Main(string[] args)
        {
            #region List<T>

            //List<Employee> List_Emp = new List<Employee>();
            //while(true)
            //{
            //    Employee employee = new Employee();
            //    Console.WriteLine("No:");
            //    employee.No = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Name:");
            //    employee.Name = Console.ReadLine();

            //    Console.WriteLine("Address:");
            //    employee.Address = Console.ReadLine();

            //    List_Emp.Add(employee);

            //    Console.WriteLine("Do you want continue: Yes / NO");
            //    string choice = Console.ReadLine();
            //    if(choice=="N")
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine("Data Added");
            //foreach(Employee list in List_Emp)
            //{
            //    Console.WriteLine(list.GetDetails()); 
            //}
            #endregion

            Employee emp1 = new Employee(101, "vivek", "Hyd");
            Employee emp2 = new Employee(102, "Mahesh", "pune");
            Employee emp3 = new Employee(103, "Rahul", "Karad");
            Employee emp4 = new Employee(104, "Akash", "Karad");

            #region stack

            /*Stack<Employee> emp = new Stack<Employee>();
            emp.Push(emp1);
            emp.Push(emp2);
            emp.Push(emp3);
            emp.Push(emp4);

            foreach (Employee employee in emp)
            {
                Console.WriteLine(employee.GetDetails());
            }*/
            #endregion

            #region Queue

            /*Queue<Employee> q = new Queue<Employee>();

            q.Enqueue(emp1);
            q.Enqueue(emp2);
            q.Enqueue(emp3);
            q.Enqueue(emp4);

            //q.Dequeue();
            foreach (Employee que in q)
            {
                
                Console.WriteLine(que.GetDetails());
            }*/
            #endregion

            #region Dictionary

            /*
            Dictionary<int, Employee> pairs = new Dictionary<int, Employee>();
            pairs.Add(emp1.No, emp1);
            pairs.Add(emp2.No, emp2);
            pairs.Add(emp3.No, emp3);
            pairs.Add(emp4.No, emp4);

            Console.WriteLine("Enter key you want to search Employee Details:");
            int key = Convert.ToInt32(Console.ReadLine());
            Employee found = pairs[key];
            Console.WriteLine(found.GetDetails());

            */
            /*foreach (int key in pairs.Keys)
            {
                Employee e = pairs[key];
                Console.WriteLine(e.GetDetails());
            }*/

            #endregion

        }
    }

    public class Employee
    {
        private int _No;
        private string _Name;
        private string  _Address;

        public string  Address
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

        public string GetDetails()
        {
            return string.Format("{0},{1},{2}", this.No, this.Name, this.Address);
        }

    }
}
