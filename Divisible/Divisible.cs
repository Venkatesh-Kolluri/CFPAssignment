namespace Divisible
{
    internal class Divisible
    {
        static void Main(string[] args) 
        {
            int start = 2000;
            int end = 3200;

            string result = "";
            for(int i = start; i <= end; i++)
            {
                if(i % 7==0 && i%5 != 0)
                {
                   result += i+",";
                }
            }
            Console.WriteLine(result);
        }
    }
}