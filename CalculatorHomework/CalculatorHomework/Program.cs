using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2 = 0;
            
            //For BMI: NUM1 = METRICS / NUM2 = KG

            //Display the title of program
            Console.WriteLine("Console Line Calculator\n-----------------------\n");

            //Ask user the to enter first number
            Console.WriteLine("Type the Number, Press Enter Key");
            num1 = Convert.ToDouble(Console.ReadLine());

            //Ask user the to enter second number
            Console.WriteLine("Type Another Number, Press Enter Key");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please select a options: " +
                "\n1.Add\n2.Subtract\n3.Multiply\n4.Divide\n5.BMI");

            //Switch statement for the calculation formula
            //First read the console input 
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"\nYour result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "2":
                    Console.WriteLine($"\nYour result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "3":
                    Console.WriteLine($"\nYour result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "4":
                    Console.WriteLine($"\nYour result: {num1} / {num2} = " + (num1 / num2));
                    break;
                case "5":
                    Console.WriteLine($"\nYour result: {num1} / {((num2 / 100) * (num2 / 100))} = " + num1 / ((num2 / 100) * (num2 / 100)));
                    break;
            }

            Console.Write("\nPress any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}
