 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
  public class InputConverter
    {
        public double ConvertToNumeric(string Input)

        {
          
            if (!double.TryParse(Input, out var number))
            {
                throw  new ArgumentException("The input is not Numeric");
            }

            return number;
        }
    }
}
