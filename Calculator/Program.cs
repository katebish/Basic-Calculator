using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConverter converter = new InputConverter();
                CalculatorEngine calc = new CalculatorEngine();

                double num1 = converter.ConvertInputToNumeric(Console.ReadLine());
                string operation = Console.ReadLine();
                double num2 = converter.ConvertInputToNumeric(Console.ReadLine());

                double result = calc.Calculate(num1, operation, num2);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
