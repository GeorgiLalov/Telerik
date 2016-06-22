namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class IEnumerableExtensionMethods
    {
        // sum enumerable and return sum
        public static T Sum<T>(this IEnumerable<T> enumerable)
            where T : struct
        {
            T sum = default(T);
            Console.WriteLine("Extension IEnumerable SUM()");

            foreach (T item in enumerable)
            {
                sum += (dynamic)item;
            }

            return sum;
        }

        // product enumerable and return product
        public static T Product<T>(this IEnumerable<T> enumerable)
            where T : struct
        {
            T product = default(T);
            product = (dynamic)product + 1;
            Console.WriteLine("Extension IEnumerable PRODUCT()");

            foreach (T item in enumerable)
            {
                product *= (dynamic)item;
            }

            return product;
        }

        // return min element of enumerable
        public static T MinElement<T>(this IEnumerable<T> enumerable)
            where T : struct, IComparable<T>
        {
            T min = default(T);
            Console.WriteLine("Extension IEnumerable MIN()");

            foreach (T item in enumerable)
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }
            }

            return min;
        }

        // return max element of enumerable
        public static T MaxElement<T>(this IEnumerable<T> enumerable)
            where T : struct, IComparable<T>
        {
            T max = default(T);
            Console.WriteLine("Extension IEnumerable MAX()");

            foreach (T item in enumerable)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }

            return max;
        }

        // return average of enumerable
        public static T Average<T>(this IEnumerable<T> enumerable)
            where T : struct, IComparable<T>
        {
            T avg = default(T);
            T sum = default(T);
            T count = default(T);
            Console.WriteLine("Extension IEnumerable AVG()");

            foreach (T item in enumerable)
            {
                sum += (dynamic)sum;
                count += (dynamic)1;
            }

            avg = (dynamic)sum / (dynamic)count;

            return avg;
        }
    }
}
