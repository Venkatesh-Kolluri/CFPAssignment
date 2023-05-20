namespace NumberToString
{
    internal class NumbersToString
    {
        public static string ConvertNumberToString(int num)
        {
            string result = "";
            if(num %3==0)
            {
               result += "Pling";
            }
            if(num %5==0)
            {
               result += "Plang";
            }
            if(num %7==0)
            {
               result += "Plong"; 
            }
            if (string.IsNullOrEmpty (result))
            {
                result=num.ToString ();
            }
          
            return result;

        }
        static void Main(string[] args)
        {
            int i = 30;
            int j = 28;
            int k = 34;
            string a =ConvertNumberToString(i);
            string b=ConvertNumberToString(j);
            string c=ConvertNumberToString(k);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

        }
    }
}