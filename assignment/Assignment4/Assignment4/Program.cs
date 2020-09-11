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
       public static Dictionary<int, Department> DeptList = new Dictionary<int, Department>();

        public static void LoadDept()
        {
            #region Load Dept
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
            reader = null; 
            #endregion

        }
        public static void LoadEmp()
        {

            #region Load Emp
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
                int deptno = int.Parse(empDetails[5]);
                DeptList[deptno].employees.Add(emp);
            }

            reader = null;
            fs.Close(); 
            #endregion
        }
        public static double Calcluate_Total_Salary()
        {
            #region Calcluate_Total_Salary
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
            #endregion
        }

        public static List<Employee> GetAllEmployeesByDept(int number)
        {
                return DeptList[number].employees;
        }

        public static Dictionary<int ,int >  DeptwiseStaffCount (Dictionary<int,Department> DeptList)
        {
            #region DeptwiseStaffCount
            Dictionary<int, int> staffCount = new Dictionary<int, int>();
            foreach (int key in DeptList.Keys)
            {
                staffCount[key] = DeptList[key].employees.Count;
            }
            return staffCount; 
            #endregion
        }

        public static Dictionary<int, Double> DeptwiseAvgSal(Dictionary<int , Department>  DeptList)
        {
            #region DeptwiseAvgSal
            Dictionary<int, double> AvgSal = new Dictionary<int, double>();

            foreach (int key in DeptList.Keys)
            {
                List<Employee> emp = DeptList[key].employees;
                double avgsal = 0.0;
                foreach (Employee e in emp)
                {
                    avgsal += e.Salary;
                }
                AvgSal[key] = avgsal / DeptList[key].employees.Count;
            }
            return AvgSal; 
            #endregion

        }
        public static Dictionary<int, Double> DeptwiseMinSal(Dictionary<int , Department> DeptList)
        {
            #region DeptwiseMinSal
            Dictionary<int, double> minSal = new Dictionary<int, double>();
            foreach (int key in DeptList.Keys)
            {
                List<Employee> emp = DeptList[key].employees;
                double minsal = Int32.MaxValue;
                foreach (Employee e in emp)
                {
                    if (e.Salary < minsal)
                        minsal = e.Salary;

                    minSal[key] = minsal;
                }
                
            }
            return minSal; 
            #endregion
        }
        public static int menulist()
        {
            #region MenuList

            int choice;
            Console.WriteLine(" welcome to HR department Application ");
            Console.WriteLine("0. EXIT");
            Console.WriteLine("1. Calcluate_Total_Salary");
            Console.WriteLine("2. GetAllEmployeesByDept");
            Console.WriteLine("3. DeptwiseStaffCount");
            Console.WriteLine("4. DeptwiseAvgSal");
            Console.WriteLine("5. DeptwiseMinSal");
            Console.WriteLine("Enter your choice : ");
            choice = Convert.ToInt32(Console.ReadLine());
            return choice; 
            #endregion
        }
        static void Main(string[] args)
        {
            #region Main Method

            LoadDept();
            LoadEmp();
            int choice;
            while ((choice = menulist()) != 0)
            {
                switch (choice)
                {
                    case 1:
                        double totalSalary = Calcluate_Total_Salary();
                        Console.WriteLine(totalSalary.ToString());
                        break;
                    case 2:
                        Console.WriteLine("Enter the department to which employee details get");
                        int number = Convert.ToInt32(Console.ReadLine());
                        List<Employee> Emp = GetAllEmployeesByDept(number);
                        foreach (Employee emp in Emp)
                        {
                            Console.WriteLine(emp.ToString());
                        }
                        break;
                    case 3:

                        Dictionary<int, int> dict = DeptwiseStaffCount(DeptList);
                        foreach (int key in dict.Keys)
                        {
                            Console.WriteLine("the staff in the DeptNo is with Dept count" + key + "is" + dict[key]);
                        }
                        break;

                    case 4:

                        Dictionary<int, Double> avgsal = DeptwiseAvgSal(DeptList);
                        foreach (int count in avgsal.Keys)
                        {
                            Console.WriteLine("the avg salary of deptNo with dept salary" + count + " is " + avgsal[count]);
                        }
                        break;
                    case 5:
                        Dictionary<int, Double> minsal = DeptwiseMinSal(DeptList);
                        foreach (int key in minsal.Keys)
                        {
                            Console.WriteLine("the min salary of deptNo with min salary" + key + " is" + minsal[key]);
                        }
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

            #endregion
        }


    }

}

