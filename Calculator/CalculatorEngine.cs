using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorEngine
    {
        public double Calculate(double num1, string operation, double num2)
        {
            double result;

            switch (operation)
            {
                case "+":
                case "add":
                    result = num1 + num2;
                    break;
                case "-":
                case "subtract":
                    result = num1 - num2;
                    break;
                case "*":
                case "multiply":
                    result = num1 * num2;
                    break;
                case "/":
                case "divide":
                    result = num1 / num2;
                    break;
                default:
                    throw new InvalidOperationException("Specified operation is not recognised");
            }

            return result;
                
        }
    }
}
