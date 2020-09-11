using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
   public class Employee
    {

        private int _Empno;
        private string _Name;
        private string _Designation;
        private Double _Salary;
        private Double _Commission;
        

        

        public Double Commission
        {
            get { return _Commission; }
            set { _Commission = value; }
        }

        
        public Double Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }

        public string Designation
        {
            get { return _Designation; }
            set { _Designation = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int Empno
        {
            get { return _Empno; }
            set { _Empno = value; }
        }

        public Employee()
        {
            _Empno = 0;
            _Name = "";
            _Designation = "";
            _Salary = 0.0;
            _Commission = 0.0;
            
        }
        public Employee(int empno, string name, string designation, double salary, double commission, int deptNo)
        {
            _Empno = empno;
            _Name = name;
            _Designation = designation;
            _Salary = salary;
            _Commission = commission;
            
        }

        public override string ToString()
        {
            return this._Empno+","+this.Name+","+this._Designation+","+this.Salary+","+this.Commission ;
        }
    }
}
