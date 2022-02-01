using Calculator.Lib;
using System;

namespace Calculator.ConsoleTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = 5;
            var y = 10;
            var y_error = 0;
            
            var add = Calc.Add(x, y);
            Console.WriteLine($"{x} + {y} = {add}");

            var div = Calc.Div(x, y);
            Console.WriteLine($"{x} / {y} = {div}");

            try
            {
                var div_error = Calc.Div(x, y_error);
                Console.WriteLine($"{x} / {y_error} = {div_error}");
            }
            catch (DivideByZeroException e)
            {

                Console.WriteLine("Делить на ноль нельзя");
            }
        }
    }
}
