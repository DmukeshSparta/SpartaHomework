using System;

namespace ComparableInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Item();
            var b = new Item();
            a.Name = "Bob";
            b.Name = "Carly";
            Console.WriteLine("{0} compared to {1} is {2}", a.Name, b.Name, a.CompareTo(b));
            a.Name = "Carly";
            b.Name = "Carly";
            Console.WriteLine("{0} compared to {1} is {2}", a.Name, b.Name, a.CompareTo(b));
            a.Name = "Edward";
            b.Name = "Carly";
            Console.WriteLine("{0} compared to {1} is {2}", a.Name, b.Name, a.CompareTo(b));

            Comparison comp = new Comparison();
            comp.CompareByName();
            comp.CompareByLength();

                
            Console.ReadLine();
        }
    }
    public class Item : IComparable
    {
        public string Name;

        public int CompareTo(object o)
        {
            Item that = o as Item;
            return this.Name.CompareTo(that.Name);
        }
    }

    interface ICompareByName
    {
        int CompareByName();
        
    }
    interface ICompareByLength
    {
        int CompareByLength();
    }

    class Comparison : ICompareByName, ICompareByLength
    {
        public string Name { get; set; }

        public int CompareByLength()
        {
            if (Name.Length > Name.Length)
            {
                Console.Write("String 1 is longer than string 2.");
            }
            else if (Name.Length == Name.Length)
            {
                Console.Write("String is same length.");
            }
            else if (Name.Length < Name.Length)
            {
                Console.Write("String 1 is shorter than string 2");
            }
            return int.Parse(Name);
        }

        public int CompareByName()
        {
            if (Name.CompareTo(Name) == 0)
            {
                Console.WriteLine($"Both strings have same value.");
            }
            else if (Name.CompareTo(Name) < 0)
            {
                Console.WriteLine($"{Name} String A below as B string alphabetically {Name}.");
            }
            else if (Name.CompareTo(Name) > 0)
            {
                Console.WriteLine($"{Name} String A above as B string alphabetically {Name}.");
            }
            return int.Parse(Name);
        }
    }
}
