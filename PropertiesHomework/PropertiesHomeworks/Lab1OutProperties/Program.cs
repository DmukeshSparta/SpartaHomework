using System;

namespace Lab1OutProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            Addition(out x, out y, out z);

            Console.WriteLine("The Addition of the Value: {0}", x, y, z);
            Console.ReadLine();

        }
        public static void Addition(out int x, out int y, out int z)
        {
            x = 20;
            y = 30;
            z = 40;

            x += y += z;
        }
    }
}
