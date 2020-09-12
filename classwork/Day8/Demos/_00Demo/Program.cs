using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Soap;
namespace _00Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            #region SOAP Serialization
            /*Employee emp = new Employee();
            emp.No = 100;
            emp.Name = "mahesh";
            emp.Address = "pune";


            FileStream fs = new FileStream(@"D:\KDAC_Online_COurse\msnet_vivek_36441\classwork\Day8\Demos\DataInSOAPFormat.xml",
                                            FileMode.OpenOrCreate,
                                            FileAccess.Write);

            SoapFormatter soapFormatter = new SoapFormatter();
            soapFormatter.Serialize(fs, emp);

            soapFormatter = null;
            fs.Flush();
            fs.Close();
            fs = null;*/
            #endregion

            #region SOAP DeSerialization

            /*FileStream fs = new FileStream(@"D:\KDAC_Online_COurse\msnet_vivek_36441\classwork\Day8\Demos\DataInSOAPFormat.xml",
                                            FileMode.Open,
                                            FileAccess.Read);

            SoapFormatter soapFormatter = new SoapFormatter();
            Employee emp = (Employee)soapFormatter.Deserialize(fs);

            Console.WriteLine(string.Format("No = {0}, Name = {1}, Address = {2}", emp.No, emp.Name, emp.Address));
            Console.ReadLine();
            soapFormatter = null;
            fs.Close();
            fs = null;*/

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

    }
}
