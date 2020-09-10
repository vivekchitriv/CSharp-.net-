using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// C# collection types are designed to store, manage and manipulate similar data more efficiently. Data manipulation includes adding, removing, finding, and inserting data in the collection. Collection types implement the following common functionality: 
///Adding and inserting items to a collection
/////*Removing items from a collection
////Finding, sorting, searching items
////Replacing items
////Copy and clone collections and items
////Capacity and Count properties to find the capacity of the collection and number of items in the collection
////.NET supports two types of collections, generic collections and non-generic collections. Prior to .NET 2.0, it was just collections and when generics were added to .NET, generics collections were added as well.
 
////Generic collections with work generic data type. Learn more about generics here: Generics in C#. 
 
////The following table lists and matches these classes.
 
//// Non-generic                          Generic
//// ArrayList     ------------->          List
//// HashTable  ------------->          Dictionary
//// SortedList   ------------->          SortedList  
//// Stack           ------------->          Stack
//// Queue         ------------->          Queue

////1. Non-Generic
////In non-generic collections, each element can represent a value of a different type. The collection size is not fixed. Items from the collection can be added or removed at runtime. 
////*/
/// </summary>
namespace _06Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region simple Dictionary
            /*Dictionary<string, int> pairs = new Dictionary<string, int>();
            pairs.Add("Dog", 1);
            pairs.Add("cat", 2);
            pairs.Add("camel", 0);
            pairs.Add("iguana", -1);
            Console.WriteLine(pairs.Count);
            Console.ReadLine();*/
            #endregion

            List<string> city = new List<string> { "Mumbai", "Hydrabad", "Delhi", "Bhopal" };
            List<string> states = new List<string> { "maharastra", "telangana", "Delhi", "MadhyaPradesh" };

            Dictionary<string, List<string>> pair = new Dictionary<string, List<string>();

            for (int i = 0; i < city.Count; i++)
            {
                pair.Add(city[i].ToString());
            }
            foreach (var data in pair)
            {
                Console.WriteLine("{0} == {1}",data.Key,data.Value);

            }
            Console.ReadLine();

            /*var keys = new List<string> { "Kalu", "Kishan", "Gourav" };
            var values = new List<string> { "Singh", "Paneri", "Jain" };

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            for (int i = 0; i < keys.Count; i++)
            {

                dictionary.Add(keys[i].ToString(), values[i].ToString());
            }
            foreach (var data in dictionary)
            {
                Console.WriteLine("{0} {1}", data.Key, data.Value);

            }
            Console.ReadLine();*/

        }
    }
}
