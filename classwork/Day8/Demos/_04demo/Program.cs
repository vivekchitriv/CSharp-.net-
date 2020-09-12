using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Demo
{// public delegate void EventHandler(object Sender, EventArgs e)
    public delegate void LogDelegate();
    //One customer ...
    class Program
    {
        static void Main(string[] args)
        {

            //  Button button1 = new Button() 
            SqlServer dbObj = new SqlServer();

            //EventHandler fnPointer = new EventHandler(DoSomething);
            LogDelegate pointerToMethodToBeCalledAfterInsert = new LogDelegate(LetMeKnowHereOnInsert);

            LogDelegate pointerToMethodToBeCalledAfterUpdate =
                new LogDelegate(LetMeKnowHereOnUpdate);

            LogDelegate pointerToMethodToBeCalledAfterDelete =
                new LogDelegate(LetMeKnowHereOnDelete);

            // button1.click += fnPointer;
            dbObj.OnInsert += pointerToMethodToBeCalledAfterInsert;
            dbObj.OnUpdate += pointerToMethodToBeCalledAfterUpdate;
            dbObj.OnDelete += pointerToMethodToBeCalledAfterDelete;

            Console.WriteLine("1: Insert, 2: Update, 3: Delete");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    dbObj.Insert();     //This is just like as if you clicked on the button
                    break;
                case 2:
                    dbObj.Update();
                    break;
                case 3:
                    dbObj.Delete();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
            Console.ReadLine();

        }

        //public void DoSomething(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Test");
        //}
        static void LetMeKnowHereOnInsert()
        {
            Console.WriteLine("Got it! Insert Has happened in DB .. I am logging it in DB");
        }

        static void LetMeKnowHereOnUpdate()
        {
            Console.WriteLine("Got it! Update Has happened in DB .. I am logging it in File");
        }

        static void LetMeKnowHereOnDelete()
        {
            Console.WriteLine("Got it! Delete Has happened in DB .. I am EMailing it to some people");
        }
    }


    public class SqlServer                      //public class Button
    {
        public event LogDelegate OnInsert;      //public event EventHandler Click
        public event LogDelegate OnUpdate;
        public event LogDelegate OnDelete;
        public void Insert()
        {
            Console.WriteLine("Data Inserted into SQL Server");
            OnInsert();                         //If user clicks then Click(this, new EventArgs);
        }

        public void Update()
        {
            Console.WriteLine("Data Updated into SQL Server");
            OnUpdate();
        }

        public void Delete()
        {
            Console.WriteLine("Data Deleted from SQL Server");
            OnDelete();
        }
    }
}
