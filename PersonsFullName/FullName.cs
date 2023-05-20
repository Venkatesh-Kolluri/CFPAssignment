namespace PersonsFullName
{
    internal class FullName
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter FirstName: ");
            string firstName=Console.ReadLine();
         
            Console.WriteLine("Enter MiddleName: ");
            string middleName=Console.ReadLine();
         
            Console.WriteLine("Enter LastName: ");
            string lastName=Console.ReadLine();

            string[] name = { firstName, middleName, lastName };

            int Count= name.Length;
            string fullName = string.Join(" ", name);

            Console.WriteLine("Number of parts in the name: "+Count);
            Console.WriteLine("FullName of a person is: "+fullName);
            
        }
    }
}