namespace _1.Calculation_Problem
{
    using System;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            string[] catNumsConsole = Console.ReadLine().Split(' ');
            int sumDecimal = 0;

            for (int index = 0; index < catNumsConsole.Length; index++)
            {
                sumDecimal += CatToDecimal(catNumsConsole[index]);
            }

            Console.WriteLine("{0} = {1}", DecimalToCat(sumDecimal), sumDecimal);

        }

        static int CatToDecimal(string number){
            int dec = 0;
            int catBase = 23;

            foreach (char catChar in number)
            {
                dec = (catChar - 'a') + dec * catBase;
            }

            return dec;
        }

        public static string DecimalToCat(int decimalNumber)
        {
            int catBase = 23;
            string digits = "abcdefghijklmnopqrstuvw";
            StringBuilder catNumber = new StringBuilder();

            while (decimalNumber != 0)
            {
                
                catNumber.Append(digits[decimalNumber % catBase]);
                decimalNumber /= catBase;
            }

            return Reverse(catNumber.ToString());
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
