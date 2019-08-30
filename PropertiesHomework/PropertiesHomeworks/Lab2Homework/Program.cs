using System;
using System.Web.Script.Serialization;

namespace Lab2Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Cats TibbyCat = new Cats("Tibby", 2);
            Cats.Age(TibbyCat);
            Cats.Age(TibbyCat);

            var json = new JavaScriptSerializer().Serialize(TibbyCat);
            Console.WriteLine(json.ToString());

            Console.ReadLine();
        }
    }
}
