using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Department
    {
        private int _DeptNo;
        private string _DeptName;
        private string _Location;
        private List<Employee> _employees;

        public List<Employee> employees
        {
            get { return _employees; }
            set { _employees = value; }
        }

        public string Location
        {
            get { return _Location; }
            set { _Location = value; }
        }

        public string DeptName
        {
            get { return _DeptName; }
            set { _DeptName = value; }
        }

        public int DeptNo
        {
            get { return _DeptNo; }
            set { _DeptNo = value; }
        }

        public Department()
        {

        }

        public Department(int deptNo, string deptName, string location)
        {
            _DeptNo = deptNo;
            _DeptName = deptName;
            _Location = location;
        }

        public override string ToString()
        {
            return this.DeptNo+", "+this.DeptName+", "+this.Location;
        }
    }
}
