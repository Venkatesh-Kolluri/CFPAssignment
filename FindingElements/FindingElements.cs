namespace FindingElements
{
    internal class FindingElements
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a string: ");
            string userInput = Console.ReadLine();

            bool isAPresent = userInput.Contains("a");
            bool isEPresent = userInput.Contains("e");
            bool isPPresent = userInput.Contains("p");

            if (isAPresent && isEPresent && isPPresent)
            {
                Console.WriteLine("All Present");
            }
            else if (isAPresent || isEPresent || isPPresent)
            {
                Console.WriteLine("One or more - Present");
            }
            else
            {
                Console.WriteLine("None Present");
            }
        }
    }

}
