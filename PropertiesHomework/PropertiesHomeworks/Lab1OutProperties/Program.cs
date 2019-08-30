using System;

namespace Lab1OutProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Declare a method which inputs three integers and returns the 
             * product ie the value of the three numbers multiplied together. 
             * Also return an out parameter which contains the sum of the three integers.
             */

            int sum = 0;

            Program p = new Program();

            int addnumber = p.Integers(20, 30, 40, out sum);
            int multiplenumber = p.Integers(20, 30, 40, out addnumber);

            Console.WriteLine("The Addition of the Value: {0}", addnumber);
            Console.WriteLine("The Multiplication of the value: {0}", multiplenumber);
            Console.ReadLine();

        }
        public int Integers(int x, int y, int z, out int sum)
        {
            sum = x + y + z;
            return x * y * z;
        }
    }
}
