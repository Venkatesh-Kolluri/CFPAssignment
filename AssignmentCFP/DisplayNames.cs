namespace AssignmentCFP
{
    internal class DisplayNames
    {
        static void Main(string[] args)
        {
            string[] names = { "Dinesh", "Prashant", "Rushi", "Sagar", "Ganesh" };
            int i = 0;
            while(i < names.Length)
            {
                Console.WriteLine((i+1)+") "+names[i]);
                i++;
            }
        }
    }
}