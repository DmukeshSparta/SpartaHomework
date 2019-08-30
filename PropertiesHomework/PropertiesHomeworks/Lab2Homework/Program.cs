using System;
using System.Web.Script.Serialization;

namespace Lab2Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Call method from Cats class
            Cats TibbyCat = new Cats("Tibby", 2);
            Cats.Age(TibbyCat);
            Cats.Age(TibbyCat);
 
            //to help you serialize the final cat object into JSON and return this JSON string.
            var json = new JavaScriptSerializer().Serialize(TibbyCat);
            Console.WriteLine(json.ToString());

            Console.ReadLine();
        }
    }
}
