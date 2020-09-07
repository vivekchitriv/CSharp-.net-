using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04OOPDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            DataBase db = new SQLServer();
            db.insert();
            db.delete();
            db.update();
            Console.ReadLine();
        }
    }

    public interface DataBase
    {
         void insert();

         void update();

        void delete();

    }
    public class SQLServer : DataBase
    {
        public void delete()
        {
            Console.WriteLine("Delete from Customer:");
        }

        public void insert()
        {
            Console.WriteLine("Insert into customer");
        }

        public void update()
        {
            Console.WriteLine("Update into customer");
        }
    }
}
