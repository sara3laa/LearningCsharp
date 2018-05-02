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
                Console.WriteLine("Enter a number");
                double firstnumber = inputconverter.ConvertToNumeric(Console.ReadLine());
                Console.WriteLine("Enter an operator");
                string operation = Console.ReadLine();
                Console.WriteLine("Enter a number");
                double secondnumber = inputconverter.ConvertToNumeric(Console.ReadLine());
                double result = caclulator.Calculate(operation, firstnumber, secondnumber);

                ConsoleKeyInfo cki;

                do
                {
                    
                    firstnumber = result;
                    Console.WriteLine("\nEnter an operator");
                    cki = Console.ReadKey();
                  
                    if (cki.Key == ConsoleKey.OemPlus)
                    {
                        break;
                        
                    }
                    Console.WriteLine("\nEnter a number");
                    secondnumber = inputconverter.ConvertToNumeric(Console.ReadLine());
                    
                    operation = Convert.ToString(cki.Key);
                   
                    result = caclulator.Calculate(operation, result, secondnumber);


                } while (true);
                
                    
               
                Console.WriteLine(" "+result);
            }
            catch (Exception ex)
            {
                //TODO:strat logging Exception
                Console.WriteLine(ex.Message);
            }
        }
    }
}
