﻿using System;

namespace Lab1OutProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Declare a method which inputs three integers and returns the product 
             * ie the value of the three numbers multiplied together. Also return an out 
             * parameter which contains the sum of the three integers.
             */

            int addition;
            int sum = 0;

            Console.WriteLine("The Addition of the Value: {0}", sum);
            Console.WriteLine("The Multiplication of the value: {0}", sum);
            Console.ReadLine();

        }
        public int Addition(int x, int y, int z, out int sum)
        {
            sum = x + y + z;
            return x * y * z;
        }
    }
}
