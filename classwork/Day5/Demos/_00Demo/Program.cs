using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Logger logger = new Logger();

            Logger.CurrentLogger.Log("CurrentLogger");
            //_logger.Log("Main method logger contain..");

            SQLServer sql = new SQLServer();
            sql.Insert();
            Console.ReadLine();
        }
    }
    public class SQLServer
    {
        //Logger logger = new Logger();
        public void Insert()
        {
            Console.WriteLine("Insert Query Here...");
            Logger.CurrentLogger.Log("Insert is being called..");
        }
    }
    public class Logger
    {
        private static Logger logger = new Logger();
        private Logger()
        {
            Console.WriteLine("new logger Object is created");
        }
        public static Logger CurrentLogger
        {
            get
            {
                return logger;
            }
        }

        public void Log(string message)
        {
            Console.WriteLine("Logged"+DateTime.Now.ToString()+" "+message);
        }
    }
}
