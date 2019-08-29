using System;

namespace CalculatorOPPHomework
{
    class BMI
    {
        public void BmiCalc()
        {
            int weight;
            double height;
            string PersonBmi;
            double BMI;

            Console.WriteLine("Enter your Height(Metre): ");
            height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your Weight(Kilogram): ");
            weight = Convert.ToInt32(Console.ReadLine());

            BMI = weight / Math.Pow(height / 100.0, 2);

            if (BMI < 18)
            {
                PersonBmi = "Underweight";
            }
            else if (BMI >= 18.5 & BMI < 24.9)
            {
                PersonBmi = "Normal";
            }
            else if (BMI >= 25 & BMI <= 29.9)
            {
                PersonBmi = "Overweight";
            }
            else
            {
                PersonBmi = "Obesity";
            }
            Console.WriteLine("BMI:  " + BMI + "\nBMI Status:  " + PersonBmi);
            Console.ReadLine();
        }
    }
}

