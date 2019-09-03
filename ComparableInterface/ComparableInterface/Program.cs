using System;

namespace ComparableInterface
{
    class Program
    {
        static void Main(string[] args)
        {
/*            var a = new Item();
            var b = new Item();
            a.Name = "Bob";
            b.Name = "Carly";
            Console.WriteLine("{0} compared to {1} is {2}", a.Name, b.Name, a.CompareTo(b));
            a.Name = "Carly";
            b.Name = "Carly";
            Console.WriteLine("{0} compared to {1} is {2}", a.Name, b.Name, a.CompareTo(b));
            a.Name = "Edward";
            b.Name = "Carly";
            Console.WriteLine("{0} compared to {1} is {2}", a.Name, b.Name, a.CompareTo(b));*/

            Comparison comp = new Comparison();
            Comparison comp1 = new Comparison();
            comp.Name = "Dipak";
            comp1.Name = "brandon";
            comp.CompareByName(comp1);
            comp.CompareByLength(comp1);


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
        int CompareByName(object name);
        
    }
    interface ICompareByLength
    {
        int CompareByLength(object name);
    }

    class Comparison : ICompareByLength, ICompareByName
    {
        public string Name { get; set; }

        public int CompareByLength(object name)
        {
            Comparison that = name as Comparison;
            if (Name.Length > that.Name.Length)
            {
                Console.WriteLine($"{Name} longer as alphabetically {that.Name}.");
            }
            else if (Name.Length == that.Name.Length)
            {
                Console.WriteLine($"Both {Name} and {that.Name} have same value.");
            }
            else if (Name.Length < that.Name.Length)
            {
                Console.WriteLine($"{Name} shorter as alphabetically {that.Name}.");
            }
            return 0;

        }

        public int CompareByName(object name)
        {
            Comparison that = name as Comparison;

            if (string.Compare(Name,that.Name) == 0)
            {
                Console.WriteLine($"Both {Name} and {that.Name} have same value.");
            }
            else if (string.Compare(Name, that.Name) < 0)
            {
                Console.WriteLine($"{Name} below as alphabetically {that.Name}.");
            }
            else if (string.Compare(Name, that.Name) > 0)
            {
                Console.WriteLine($"{Name} above as alphabetically {that.Name}.");
            }
            return string.Compare(Name, that.Name);
        }
    }
}
