namespace Factorial
{
    internal class FactorialProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to find factorial");
            int num=int.Parse(Console.ReadLine());

            int fact = Factorial(num);
            Console.WriteLine("The factorial value is: "+fact);
        }
        public static int Factorial(int value)
        {
            int result = 1;
            for(int i = 2; i <= value; i++)
            {
                result=result*i;

            }
            return result;
        }
    }
}