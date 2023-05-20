using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SquareOfNumbers
{
    public class NumbersSquare
    {
        double Num1;
        double Num2;
        public void Square()
        {
            Console.WriteLine("Enter first number: ");
            Num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            Num2= Convert.ToDouble(Console.ReadLine());

            double add = Num1 + Num2;
            double sumSquare=Math.Pow(add,2);
            Console.WriteLine($"The square of sum of these two numbers {Num1} & {Num2} is {sumSquare}");

            double sub=Num1 - Num2;
            double diffSquare=Math.Pow(sub,2);
            Console.WriteLine($"The square of difference of these two numbers {Num1} & {Num2} is {diffSquare}");

        }
        static void Main(string[] args)
        {
            NumbersSquare value = new NumbersSquare();
            value.Square();

        }
    }
}
