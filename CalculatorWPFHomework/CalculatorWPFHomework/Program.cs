using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWPFHomework
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class CalculatorMethod
    {
        public double Divide(double num1, double num2)
        {
            double result = num1 / num2;
            return result;
        }
        public double Add(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }
        public double Subtract(double num1, double num2)
        {
            double result = num1 - num2;
            return result;
        }
        public double Multiply(double num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }
    }
}
