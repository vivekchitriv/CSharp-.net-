using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03DemoSingletonPattern
{
    internal partial class ChocolateBoiler
    {
        private static readonly Lazy<ChocolateBoiler>_singleton = new Lazy<ChocolateBoiler>(() => new ChocolateBoiler());
        private Status _boiler;

        public static ChocolateBoiler GetInstance() => _singleton.Value; 

        private ChocolateBoiler()
        {
            Console.WriteLine("Starting");
            _boiler = Status.Empty;
        }

        public void Fill( )
        {
            if (!IsEmpty) return;
            Console.WriteLine("Filling..");
            _boiler = Status.InProgress;
        }
        public void Drain ( )
        {
            if (!IsBoiled) return;
            Console.WriteLine("Draining...");
            _boiler = Status.Empty;
        }
        public void Boil( )
        {
            if (IsBoiled || IsEmpty) return;
            Console.WriteLine("Boiling..");
            _boiler = Status.Boiled;
        }

        private bool IsEmpty => (_boiler == Status.Empty);


        private bool IsBoiled => (_boiler == Status.Boiled);
    }
}
