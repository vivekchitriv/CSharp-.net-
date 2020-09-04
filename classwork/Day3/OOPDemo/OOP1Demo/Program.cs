using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP1Demo
{
    
    public class Person
    {
        private int _No;
        private string _Name;
        private string _Address;

        public int No { get => _No; set => _No = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string Address { get => _Address; set => _Address = value; }

        public Person(int no, string name, string address)
        {
            this.No= no;
            this.Name = name;
            this.Address = address;
          }


        public override string ToString()
        {
            return "Person"+ No + " " + Name + " " +Address;
        }

       







        //{
        //    set
        //    {
        //        this.name = value;

        //    }
        //    get
        //    {
        //        return this.name;
        //    }


        //}
        //private string _Name;

        /*public void Set_Name(string name)
        {
            //if(name = "1234")
            //{

            //}

            this._Name = name;
        }
        public string Get_Name( )
        {
            return this._Name;
        }*/
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Person p1 = new Person();
            //p1.Set_Name( " vivek");
            //string value = p1.Get_Name();
            //Console.WriteLine(value);
            //Console.ReadLine();

            Person p1 = new Person(101,"vivek","Hyd");
            Console.WriteLine(p1);
            Console.ReadLine();


        }
    }
}
