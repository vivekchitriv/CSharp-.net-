using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Emp e = new Emp();
            //Imagin code line here
            //Imagin code line here
            //Imagin code line here
            //Imagin code line here
            //Imagin code line here
            //Imagin code line here
            //Imagin code line here
            //Imagin code line here
            e.SomeFun();
            //Imagin code line here
            //Imagin code line here
            //Imagin code line here
            //Imagin code line here
            //Imagin code line here
            //Imagin code line here
            //Imagin code line here
            //Imagin code line here
            e = null;
            //Imagin code line here
            //Imagin code line here
            //Imagin code line here
            //Imagin code line here
            //Imagin code line here
            //Imagin code line here
            //Imagin code line here
            //Imagin code line here
            GC.Collect();
        }
    }

    class Emp
    {

        public void SomeFun()
        {
            //Imagin code line here
            //Imagin code line here
            //Imagin code line here
            //Imagin code line here
            //Imagin code line here
            //Imagin code line here
            //Imagin code line here
            //Imagin code line here
            Console.WriteLine(" You have in Emp function ::");
            Console.ReadLine();
            //Imagin code line here
            //Imagin code line here
            //Imagin code line here
            //Imagin code line here
            //Imagin code line here
            //Imagin code line here
            //Imagin code line here
            //Imagin code line here
        }

        public void DoSomeOperation()
        {
            
            {
                Emp e1 = new Emp();
               e1.SomeFun();
                //Imagin code line here
                //Imagin code line here
                //Imagin code line here
                //Imagin code line here
                //Imagin code line here
                //Imagin code line here
                //Imagin code line here
                //Imagin code line here
                e1 = null;
            }
        }
    }

}
