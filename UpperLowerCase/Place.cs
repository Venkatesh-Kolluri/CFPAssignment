using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperLowerCase
{
    internal class Place
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the place you want to visit:");
            string input = Console.ReadLine();
            string upperCase = input.ToUpper();
            Console.WriteLine($"Place you want to visit in UpperCase ==> {upperCase}");
            string lowerCase = input.ToLower();
            Console.WriteLine($"Place you want to visit in LowerCase==> {lowerCase}");
        }
        
    }
}
