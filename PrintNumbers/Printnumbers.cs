namespace PrintNumbers
{
    internal class Printnumbers
    {
        public static void Repeat(int num)
        {
            if (num == 100)
            {
                Console.Write(num);
            }
            else
            {
                Console.Write(num+" ");
                num++;
                Repeat(num);
            }
        }
        static void Main(string[] args)
        {
            Printnumbers.Repeat(1);
           
        }
    }
}