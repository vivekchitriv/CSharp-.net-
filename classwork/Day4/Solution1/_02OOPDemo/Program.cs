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
            Console.WriteLine("1: PDF , 2 : DOCX , 3 : PPT ,4: EXCEL 5 : TEXT");
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
            else if(choice == 3)
            {
                return new PPT();
            }
            else if(choice == 4)
            {
                return new Excel();
            }
            else
            {
                return new Text();
            }
        }
    }
    public abstract class Report
    {
            protected abstract void Read();
            protected abstract void Parse();
            protected abstract void Validate();
            protected abstract void Print();
        public virtual void Execute ( )
        {
            Read();
            Parse();
            Validate();
            Print();
        }
    }

    public abstract class SpecialReport:Report
    {
        protected abstract void ReValidate();
        public override void Execute()
        {
            Read();
            Parse();
            Validate();
            ReValidate();
            Print();
        }
    }

    //Architect
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


    } //Written Developer 1

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


    }   //Written Developer 2


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
    } //Written Developer 4

    public class Excel : SpecialReport //Written Developer 5 -Addition of one method
    {
        protected override void Parse()
        {
            Console.WriteLine("Excel : Parse ");
        }

        protected override void Print()
        {
            Console.WriteLine("Excel : print ");
        }

        protected override void Read()
        {
            Console.WriteLine("Excel : Read ");
        }

        protected override void Validate()
        {
            Console.WriteLine("Excel : Validate ");
        }

        protected override void ReValidate()
        {
            Console.WriteLine("Excel : ReValidate()");
        }
          
    }

    public class Text : SpecialReport//Written Developer 6
    {
        protected override void Parse()
        {
            Console.WriteLine("Text : Parse");
        }

        protected override void Print()
        {
            Console.WriteLine("Text : Print");
        }

        protected override void Read()
        {
            Console.WriteLine("Text : read");
        }

        protected override void Validate()
        {
            Console.WriteLine("Text : Validate");
        }
        protected override void ReValidate()
        {
            Console.WriteLine(" TXT : ReValidate");
        }
        
    }
}
