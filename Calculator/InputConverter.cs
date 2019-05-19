using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class InputConverter
    {
        public double ConvertInputToNumeric(string input)
        {
            double convertedNum;

            // Attempt to convert to string
            // If not converted, except it was unsuccessful
            if (!double.TryParse(input, out convertedNum)) throw new ArgumentException("Expected a numeric value from the user");
            return convertedNum;
        }
    }
}
