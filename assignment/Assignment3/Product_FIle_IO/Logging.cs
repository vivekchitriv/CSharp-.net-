using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_FIle_IO
{
    class Logger
    {

        private static Logger logger = new Logger();

        private Logger()
        {
            Console.WriteLine("New Logger object has been Created with Logger.txt file pls see this..");
        }

        public static Logger FileLogger
        {
            get
            {
                return logger;
            }
        }
        public string Log(string message)
        {
            return "Logged   " + DateTime.Now.ToString() + "  :" + message;
        }
    }
}
