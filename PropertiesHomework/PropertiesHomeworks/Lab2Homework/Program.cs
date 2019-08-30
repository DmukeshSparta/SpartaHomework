using System;

namespace Lab2Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Cats cat = new Cats("Sissy", 2);
            Console.WriteLine("Before: {0}, {1}", cat.Name, cat.Age);
            Age(cat);
            Console.WriteLine("After: {0}, {1}", cat.Name, cat.Age);

            Console.ReadLine();
        }

        public static void Age(Cats cat)
        {
            cat.Age += 5;
        }
    }
}
