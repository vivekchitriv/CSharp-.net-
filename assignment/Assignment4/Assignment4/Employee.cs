using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Employee
    {

        private int _Empno;
        private string _Name;
        private string _Designation;
        private Double _Salary;
        private Double _Commission;
        private int _DeptNo;

        public int DeptNo
        {
            get { return _DeptNo; }
            set { _DeptNo = value; }
        }

        public Double Commission
        {
            get { return _Commission; }
            set { _Commission = value; }
        }

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
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

        
        public override string ToString()
        {
            return this._Empno+","+this.Name+","+this._Designation+","+this.Salary+","+this.Commission + ","+this._DeptNo;
        }
    }
}
