namespace NextDayDate
{
    internal class Date
    {
        static void Main(string[] args)
        {
            Console.Write("Input a Year: ");
            int year=int.Parse(Console.ReadLine());
            Console.Write("\nInput a Month[1-12]: ");
            int month=int.Parse(Console.ReadLine());
            Console.Write("\nInput a Day[1-31]: ");
            int day=int.Parse(Console.ReadLine());

            DateTime currentDate=new DateTime(year, month, day);
            DateTime nextDate=currentDate.AddDays(1);
            Console.WriteLine("The next date is [yyyy-mm-dd] {0}",nextDate.ToString("yyyy-MM-dd"));
        }
    }
}