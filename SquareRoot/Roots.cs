namespace SquareRoot
{
    internal class Roots
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the coefficient a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the coefficient b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the coefficient c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double discriminant = (b * b) - (4 * a * c);

            if (discriminant > 0) //2 real roots
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                Console.WriteLine("Root 1: " + root1);
                Console.WriteLine("Root 2: " + root2);
            }
            else if (discriminant == 0) //1 real roots
            {
                double root = -b / (2 * a);
                Console.WriteLine("Root: " + root); 
            }
            else
            {
                Console.WriteLine("No real roots exist.");
            }
        }
    }

}