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
        static Dictionary<int, Department> DeptList = new Dictionary<int, Department>();

        public static void LoadDept()
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

                DeptList.Add(dept.DeptNo, dept);
                
            }

            fs.Close();
            reader=null;
            
        }
        public static void LoadEmp()
        {
            
            FileStream fs = new FileStream(@"D:\KDAC_Online_COurse\msnet_vivek_36441\assignment\Assignment4\Assignment4\emp.csv",
                FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);
            string empstring = null;

            while ((empstring = reader.ReadLine()) != null)
            {
                string[] empDetails = empstring.Split(',');
                Employee emp = new Employee();
                emp.Empno = int.Parse(empDetails[0]);
                emp.Name = empDetails[1];
                emp.Designation = empDetails[2];
                emp.Salary = double.Parse(empDetails[3]);
                emp.Commission = double.Parse(empDetails[4]);
                int dept = int.Parse(empDetails[5]);
                DeptList[dept].employees.Add(emp);
            }
            
            reader = null;
            fs.Close();
        }
        public static double Calcluate_Total_Salary()
        {
            double totalSalary = 0.0f;
            foreach (int key in DeptList.Keys)
            {
                List<Employee> emp = DeptList[key].employees;
                foreach (Employee e in emp)
                {
                    totalSalary += e.Salary + e.Commission;
                }
            }

            return totalSalary;
        }

        public static int menulist()
        {
            int choice;
            Console.WriteLine("0. EXIT");
            Console.WriteLine("1. Calcluate_Total_Salary");
            Console.WriteLine("2. GetAllEmployeesByDept");
            Console.WriteLine("3. DeptwiseStaffCount");
            Console.WriteLine("4. DeptwiseAvgSal");
            Console.WriteLine("5. DeptwiseMinSal");
            Console.WriteLine("Enter choice : ");
            choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
        static void Main(string[] args)
        {
            LoadDept();
            LoadEmp();
            int choice;
            while ((choice=menulist())!=0)
            {
                switch (choice)
                {
                    case 1:
                        double totalSalary = Calcluate_Total_Salary();
                        Console.WriteLine(totalSalary.ToString());
                        break;
                    case 2:

                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }
                Console.WriteLine("Do you want to continue! press 1. for Yes 2 . for No");
                int ch = Convert.ToInt32(Console.ReadLine());
                if (ch == 2)
                {
                    break;
                }

            }
        
        }


    }

}

