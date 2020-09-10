using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _05Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            

           

            Employee emp1 = new Employee(101, "vivek", "Hyd");
            Employee emp2 = new Employee(102, "Mahesh", "pune");
            Employee emp3 = new Employee(103, "Rahul", "Karad");
            Employee emp4 = new Employee(104, "Akash", "Karad");


            #region Single object Xml Serialization

            /*List<Employee> list_emp = new List<Employee>();
            list_emp.Add(emp1);
            
            FileStream fs = new FileStream(@"D:\KDAC_Online_COurse\msnet_vivek_36441\classwork\Day7\Demos\_05Demo\data.xml",
                FileMode.OpenOrCreate,FileAccess.Write);
            XmlSerializer writer = new XmlSerializer(typeof(Employee));

            writer.Serialize(fs, emp1);

            writer = null;
            fs.Flush();
            fs.Close();
*/
            #endregion


            #region Single object xml Deserialization

            /*FileStream fs = new FileStream(@"D:\KDAC_Online_COurse\msnet_vivek_36441\classwork\Day7\Demos\_05Demo\data.xml",
                FileMode.Open, FileAccess.Read);
            XmlSerializer reader = new XmlSerializer(typeof(Employee));

            Employee e1  = (Employee)reader.Deserialize(fs);

            Console.WriteLine(e1.GetDetails());
               
            reader = null;
            fs.Flush();
            fs.Close();
*/
            #endregion

            #region Collection Object Xml Serialize
            /*List<Employee> list= new List<Employee>();
            list.Add(emp1);
            list.Add(emp2);
            list.Add(emp3);
            list.Add(emp4);
            FileStream fs = new FileStream(@"D:\KDAC_Online_COurse\msnet_vivek_36441\classwork\Day7\Demos\_05Demo\data.xml",
                FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer writer = new XmlSerializer(typeof(List<Employee>));

            writer.Serialize(fs, list);

            writer = null;
            fs.Flush();
            fs.Close(); 
                */
            #endregion

            #region Collection Object Xml DeSerialization

            List<Employee> list = new List<Employee>();
            list.Add(emp1);
            list.Add(emp2);
            list.Add(emp3);
            list.Add(emp4);
            FileStream fs = new FileStream(@"D:\KDAC_Online_COurse\msnet_vivek_36441\classwork\Day7\Demos\_05Demo\data.xml",
                FileMode.Open, FileAccess.Read);
            XmlSerializer reader = new XmlSerializer(typeof(List<Employee>));

            List<Employee> lst = (List<Employee>)reader.Deserialize(fs);

            foreach (Employee e in lst)
            {
                Console.WriteLine(e.GetDetails());
            }
            reader = null;
            fs.Flush();
            fs.Close();
            #endregion


        }
    }

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
