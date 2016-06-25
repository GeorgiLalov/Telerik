namespace Models
{
    using System;

    public static class InfiniteConvergentSeries
    {
        public static double ConvergentSum(Func<int, double> term, double precision)
        {
            double sum = 0;
            double t = 1;
            for (int i = 0; Math.Abs(t) > precision; i++)
            {
                t = term(i);
                sum += t;
            }

            return sum;
        }

        public static long Factorial(int num)
        {
            long result = 1;
            while (num > 1)
            {
                result *= num;
                num--;
            }

            return result;
        }
    }
}
