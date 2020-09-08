using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace _01Demo
{

    class Program
    {
        static void Main(string[] args)
        {

            #region Normal File Writing

            /* FileStream fs = null;
             StreamWriter writer = null;
             string data = null;

             fs = new FileStream(@"D:\KDAC_Online_COurse\msnet_vivek_36441\classwork\Day5\Demos.Test.txt", FileMode.OpenOrCreate, FileAccess.Write);

             writer = new StreamWriter(fs);
             Console.WriteLine("Enter some statement");
             data = Console.ReadLine();
             writer.WriteLine(data);

             writer.Flush();
             fs.Flush();
             writer.Close();
             fs.Close();*/
            #endregion

            #region Normal File Reading
            /*if (File.Exists(@"D:\KDAC_Online_COurse\msnet_vivek_36441\classwork\Day5\Demos\Test.txt"))
            {
                FileStream fs = new FileStream(@"D:\KDAC_Online_COurse\msnet_vivek_36441\classwork\Day5\Demos.Test.txt",FileMode.Open,FileAccess.Read);

                StreamReader reader = new StreamReader(fs);

            string alldatafromafile = reader.ReadToEnd();

            Console.WriteLine("data from the file is: " + alldatafromafile);
                Console.ReadLine();
            reader.Close();
            fs.Close();
            }
            else
            {
                Console.WriteLine("file does not exist!");
            }*/

            #endregion

            #region Writing Object in File
            /* FileStream fs = new FileStream(@"D:\KDAC_Online_COurse\msnet_vivek_36441\classwork\Day5\Demos\Test.txt",
                                             FileMode.OpenOrCreate,
                                             FileAccess.Write);

             //StreamWriter writer = new StreamWriter(fs);
             BinaryFormatter writer = new BinaryFormatter();
             Employee employee = new Employee();

             Console.WriteLine("Enter NO");
             employee.No = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter Name");
             employee.Name = Console.ReadLine();

             Console.WriteLine("Enter Address");
             employee.Address = Console.ReadLine();

             //Console.WriteLine(employee.ToString());

             //writer.WriteLine(employee);

             writer.Serialize(fs, employee);
             //writer.Flush();
             writer = null;
             fs.Flush();
             //writer.Close();
             fs.Close();*/
            #endregion

            #region Reading Object from file
            FileStream fs = new FileStream(@"D:\KDAC_Online_COurse\msnet_vivek_36441\classwork\Day5\Demos\Test.txt",
                                            FileMode.Open,
                                            FileAccess.Read);

            //StreamWriter writer = new StreamWriter(fs);
            BinaryFormatter reader = new BinaryFormatter();
            Employee SomeEmployeeObject =(Employee) reader.Deserialize(fs);
            Console.WriteLine(SomeEmployeeObject.Name);
            Console.ReadLine();
            reader = null;
            fs.Close();
            #endregion
        }
    }

    [Serializable] // to serialize object into file
    public class Employee
    {
        #region PrivateMembers

        [NonSerialized] //for Not Saving data into file
        private int _No;
        private string _Name;
        private string _Address;

        #endregion

        #region Properties

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
        #endregion
        public Employee()
        {
            Address = "";
            Name = "";
            No = 0;
        }

        #region Constructor
        public Employee(string address, string name, int no)
        {
            Address = address;
            Name = name;
            No = no;
        }
        #endregion
    }
}
