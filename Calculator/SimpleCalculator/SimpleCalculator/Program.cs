using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var inputconverter = new InputConverter();
                var caclulator = new CalculateEngine();
                double firstnumber = inputconverter.ConvertToNumeric(Console.ReadLine());
                double secondnumber = inputconverter.ConvertToNumeric(Console.ReadLine());
                string operation = Console.ReadLine();
                double result = caclulator.Calculate(operation, firstnumber, secondnumber);

                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                //TODO:strat logging Exception
                Console.WriteLine(ex.Message);
            }
        }
    }
}
