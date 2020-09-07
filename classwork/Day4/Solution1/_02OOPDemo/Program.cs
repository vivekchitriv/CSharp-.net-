using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _02OOPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // PDF pdf = new PDF();
            // pdf.Execute();
            /* Report report = null;
             Console.WriteLine("DocX :methods");
             report = new DOCX();
             report.Execute();
             Console.WriteLine("PDF :methods");
             report = new PDF();
             report.Execute();*/
            //call factory method
            ReportFactory rf = new ReportFactory();
            Console.WriteLine("1: PDF , 2 : DOCX , 3 : PPT");
            int choice = int.Parse(Console.ReadLine());
            //call factory method
            Report report = rf.GetReport(choice);
            //execute the method
            report.Execute();
            Console.ReadLine();
        }
       
    }
    public class ReportFactory
    {
        public Report GetReport ( int choice )
        {
            if(choice == 1)
            {
                return new PDF();
            }
            else if(choice == 2)
            {
                return new DOCX();

            }
            else
            {
                return new PPT();
            }
        }
    }
    public abstract class Report
    {
            protected abstract void Read();
            protected abstract void Parse();
            protected abstract void Validate();
            protected abstract void Print();
        public void Execute ( )
        {
            Read();
            Parse();
            Validate();
            Print();
        }
    }
    public class PDF:Report
    {
        protected override void Read()
        {
            //Step 1
            Console.WriteLine("Read PDF");

        }
        protected override void Parse()
        {
            //Step 2
            Console.WriteLine("Parsing PDF");

        }

        protected override void Validate()
        {
            //Step 3
            Console.WriteLine("Validation PDF");

        }
        protected override void Print()//GOD Function
        {
            //Imagine Huge Logic here
            //Step 4
            Console.WriteLine("Pdf Getting Printing Here:");
        }

        
    }

    public class DOCX: Report
    {
        protected override void Read()
        {
            //Step 1
            Console.WriteLine("Read DOCX");

        }
        protected override void Parse()
        {
            //Step 2
            Console.WriteLine("Parsing DOCX");

        }

        protected override void Validate()
        {
            //Step 3
            Console.WriteLine("Validation DOCX");

        }
        protected override void Print()//GOD Function
        {
            //Imagine Huge Logic here
            //Step 4
            Console.WriteLine("Pdf Getting Printing Here:");
        }

        
    }

    //Developer 4
    public class PPT : Report
    {
        protected override void Parse()
        {
            Console.WriteLine(" PPT : Parse");
        }

        protected override void Print()
        {
            Console.WriteLine(" PPT : Print ");
        }

        protected override void Read()
        {
            Console.WriteLine(" PPT : Read ");
        }

        protected override void Validate()
        {
            Console.WriteLine(" PPT : Validate");
        }
    }
}
