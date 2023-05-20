namespace Circle
{
    internal class CircleArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Diameter of Circle: ");
            double d=Convert.ToDouble(Console.ReadLine());
            double r = d / 2;
            double perimeterOfCircle = 2 * (Math.PI) * r;
            Console.WriteLine($"Perimeter of circle is: {perimeterOfCircle}");
            double areaOfCircle = Math.PI * r * r;
            Console.WriteLine($"Area of Circle is: {areaOfCircle}");
        }
    }
}