namespace AverageValue
{
    internal class Average
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int num1 = random.Next(10,50);
            int num2=random.Next(10,50);
            int num3=random.Next(10,50);
            int num4=random.Next(10,50);
            int num5=random.Next(10,50);
            Console.Write( $"5 random values are: { num1} { num2} { num3} { num4} { num5}" );

            int average = (num1 + num2 + num3 + num4 + num5) / 5;
            Console.WriteLine( $"\nThe average value of 5 random numbres ==> {average}" );
        }
    }
}