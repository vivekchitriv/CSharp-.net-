using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Sealed class or sealed method 
/// It is not inherited after using sealed class or method it is like final keyword
/// </summary>
namespace _00Demo
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Button
    {
        public virtual void DoSomething()
        {

        }
    }
    public class telerikButton :Button
    {
        public sealed override void DoSomething()
        {

        }

    }
    public class TDGButton:telerikButton
    {

      /*  public override void DoSomething()
        {

        }
    }*/
}


   /* public sealed abstract class Utility
    {

    }*/