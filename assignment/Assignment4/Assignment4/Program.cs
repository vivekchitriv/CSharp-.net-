using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        
       public static  Dictionary<int, Department> DeptList = new Dictionary<int, Department>();

        //List<Department> list = new List<Department>();
        public static void  LoadDept()
        { 
            FileStream fs = new FileStream(@"D:\KDAC_Online_COurse\msnet_vivek_36441\assignment\Assignment4\Assignment4\dept.csv",
                FileMode.Open, FileAccess.Read);
            
            StreamReader reader = new StreamReader(fs);
            string deptstring;
            while ((deptstring = reader.ReadLine()) != null)
            {
                string[] deptDetails = deptstring.Split(',');
                Department dept = new Department();
                dept.DeptNo = int.Parse(deptDetails[0]);
                dept.DeptName = deptDetails[1];
                dept.Location = deptDetails[2];

                DeptList.Add(dept.DeptNo,dept);
                Console.ReadLine();
            }
        
        fs.Close();
            reader.Close();
            fs = null;
        }

        /*public static void LoadEmp() 
        { 
        FileStream fs = new FileStream(@"D:\KDAC_Online_COurse\msnet_vivek_36441\assignment\Assignment4\Assignment4\emp.csv", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);

            string EmpString;
            //List<Employee> Emplist = new List<Employee>();
            //Dictionary<int, List<Employee>> EmpDict = new Dictionary<int, List<Employee>>(); 

            while ((EmpString = reader.ReadLine()) != null)
            {
                string[] Details = EmpString.Split(',');
                Employee emp = new Employee();
                emp.Empno = int.Parse(Details[0]);
                emp.Name = Details[1];
                emp.Designation = Details[2];
                emp.Salary = float.Parse(Details[3]);
                emp.Commission = Convert.ToDouble(Details[4]);
                emp.DeptNo = int.Parse(Details[5]);
                DeptList[emp.DeptNo].employees.Add(emp);
            }*/
        }





    }
}

