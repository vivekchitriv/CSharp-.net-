using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
        private string name;
        private bool gender;
        private int age;
        private int std; 
        private char div;
        private double marks;
        

        public Student( )
        {
            Console.WriteLine("Student()::0 - param constructor");
            Console.ReadLine();
            
            this.name = null;
            this.gender = false;
            this.age = 0;
            this.std = 0;
            this.div = ' ';
            this.marks = 0.0f;

        }

        public Student(string name, bool gender, int age, int std, char div, double marks)
        {
            Console.WriteLine("public Student(string name, bool gender, int age, int std, char div, double marks)::6 - param constructor");
            Console.ReadLine();
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
            this.Std = std;
            this.Div = div;
            this.Marks = marks;
            
        }

        public string Name { get => name; set => name = value; }
        public bool Gender { get => gender; set => gender = value; }
        public int Age { get => age; set => age = value; }
        public int Std { get => std; set => std = value; }
        public char Div { get => div; set => div = value; }
        public double Marks { get => marks; set => marks = value; }

        public void AcceptDetails( )
        {
            Console.WriteLine("Enter the Name::");
            this.name = Console.ReadLine();
            
            Console.WriteLine("Enter the Gender::");
            this.gender= bool.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the Age::");
            this.age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Std::");
            this.std = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Div::");
            this.div = char.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the Marks::");
            this.marks=double.Parse(Console.ReadLine());

        }

        public void PrintDetails( )
        {
            Console.WriteLine("Name::" + this.Name);
            Console.WriteLine("Gender::" + this.gender.ToString());
            Console.WriteLine("Age::" + this.age.ToString());
            Console.WriteLine("Div::" + this.div.ToString());
            Console.WriteLine("Std::" + this.std.ToString());
            Console.WriteLine("Marks::" + this.marks.ToString());
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("vivek", true, 24, 12, 'A', 145.50);
            student.AcceptDetails();
            student.PrintDetails();
            Console.ReadLine();
        }
    }
}
