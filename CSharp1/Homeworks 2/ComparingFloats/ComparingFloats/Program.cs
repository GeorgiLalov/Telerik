using System;

class ComparingFloats
{
    static void Main(string[] args)
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double eps = 0.000001;
        bool ans = (firstNumber - secondNumber) < eps && (secondNumber - firstNumber) < eps;
        if(ans)
            Console.WriteLine("true");
        else
            Console.WriteLine("false");
    }
}
