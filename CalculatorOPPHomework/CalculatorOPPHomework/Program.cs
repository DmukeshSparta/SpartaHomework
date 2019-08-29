using System;

namespace CalculatorOPPHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            string options;
            Input datainput = new Input();
            BMI bmi1 = new BMI();

            Console.WriteLine("Console Line Calculator\n-----------------------\n");

            Console.WriteLine("Select a option: 1. Calculator, 2. BMI");
            options = Console.ReadLine();

            if (options == "1")
            {
                datainput.Optionselect();
            }
            else if (options == "2")
            {
                bmi1.BmiCalc();
            }
        }
    }

    class Addition
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }
    }

    class Subtraction
    {
        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }
    }

    class Multiplication
    {
        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
    }

    class Division
    {
        public double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }

    class Input
    {
        public void Optionselect()
        {
            string options;

            Addition add = new Addition();
            Subtraction sub = new Subtraction();
            Multiplication multi = new Multiplication();
            Division div = new Division();

            //Ask user to enter first number
            Console.WriteLine("Type the Number, Press Enter Key");
            double num1 = Convert.ToDouble(Console.ReadLine());

            //Ask user to enter second number
            Console.WriteLine("Type Another Number, Press Enter Key");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please select a option: " + "\n1.Add\n2.Subtract\n3.Multiply\n4.Divide");
            options = Console.ReadLine();

            switch (options)
            {
                case "1":
                    Console.WriteLine($"\nYour result: " + add.Add(num1, num2));
                    break;
                case "2":
                    sub.Subtract(num1, num2);
                    Console.WriteLine($"\nYour result: " + sub.Subtract(num1, num2));
                    break;
                case "3":
                    multi.Multiply(num1, num2);
                    Console.WriteLine($"\nYour result: " + multi.Multiply(num1, num2));
                    break;
                case "4":
                    div.Divide(num1, num2);
                    Console.WriteLine($"\nYour result: " + div.Divide(num1, num2));
                    break; ;
            }
            Console.ReadLine();
        }
    }
}
