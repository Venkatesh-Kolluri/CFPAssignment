namespace PrintString
{
    internal class NumString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value:");
            string num=Console.ReadLine();

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine((i+1)+") "+num);
            }
        }
    }
}