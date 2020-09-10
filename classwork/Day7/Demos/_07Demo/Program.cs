using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> list_Stud = new List<Student>();
            List<School> list_scl = new List<School>();
            School scl = new School();

            Student st = new Student();
            while (true)
            {
                Console.WriteLine("Do you want to inset data 1. Student 2 . School 3. Data");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1 :
                        
                        

                        Console.WriteLine("Enter Student No:");
                        st.No = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Student Name:");
                        st.Name = Console.ReadLine();

                        Console.WriteLine("Enter Student marks:");
                        st.Marks = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter Student Address:");
                        st.Address = Console.ReadLine();

                        Console.WriteLine("Enter Student Mobile:");
                        st.Mobile = long.Parse(Console.ReadLine());

                        list_Stud.Add(st);

                        
                        break;

                    case 2:
                        

                        Console.WriteLine("Enter School SRN No:");
                        scl.SNo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter School Name:");
                        scl.SName = Console.ReadLine();

                        Console.WriteLine("Enter School Address");
                        scl.SAddress = Console.ReadLine();

                        Console.WriteLine("Enter Student Mobile No:");
                        scl.mobile = long.Parse(Console.ReadLine());

                        list_scl.Add(scl);
                        break;
                    case 3:
                        for (int i = 0; i < list_Stud.Count; i++)
                        {
                            if(st.Mobile==scl.mobile)
                            {
                                foreach (Student data in list_Stud)
                                {
                                    Console.WriteLine(data.No);
                                    Console.WriteLine(data.Name);
                                    Console.WriteLine(data.Address);
                                    Console.WriteLine(data.Marks);
                                    Console.WriteLine(data.Mobile);
                                }


                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }

                Console.WriteLine("Do you want continue press y/n");
                string ch = Console.ReadLine();
                if(ch =="n")
                {
                    break;
                }
            }
        }
    }


    #region Student class

    public class Student
    {
        private int _No;
        private string _Name;
        private Double _Marks;
        private string _Address;
        private long _Mobile;

        public long Mobile
        {
            get { return _Mobile; }
            set { _Mobile = value; }
        }


        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        public Double Marks
        {
            get { return _Marks; }
            set { _Marks = value; }
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

        public Student()
        {

        }
        public Student(int no, string name, double marks, string address,long mobile)
        {
            _No = no;
            _Name = name;
            _Marks = marks;
            _Address = address;
            _Mobile = mobile;
        }

         public void GetSDetails()
        {
            //Console.WriteLine("No:{0} ,Name:{1} ,Marks:{2} ,Address:{3} , Mobile:{4}",this.No,this.Name,this.Marks,this.Address,this.Mobile);
            Console.WriteLine("No:{0} ,Name:{1} ,Marks:{2} ,Address:{3} , Mobile:{4}", this.No, this.Name, this.Marks, this.Address, this.Mobile);
        }

    }
    #endregion

    #region School class
    public class School
    {
        private int _SNo;
        private string _SName;
        private string _SAddress;
        private long _Mobile;

        public long mobile
        {
            get { return _Mobile; }
            set { _Mobile = value; }
        }


        public int SNo
        {
            get { return _SNo; }
            set { _SNo = value; }
        }

        public string SAddress
        {
            get { return _SAddress; }
            set { _SAddress = value; }
        }

        public string SName
        {
            get { return _SName; }
            set { _SName = value; }
        }

        public School()
        {

        }
        public School(int sNo , string sName, string sAddress ,long Mobile)
        {
            _SNo = sNo;
            _SName = sName;
            _SAddress = sAddress;
            _Mobile = Mobile;
            
        }

        public void GetDetials( )
        {
            Console.WriteLine("SNo : {0}, SName:{1}, SAddress:{2}, Mobile:{3}",this.SNo,this.SName,this.SAddress,this.mobile);
        }
    }
    #endregion
}

