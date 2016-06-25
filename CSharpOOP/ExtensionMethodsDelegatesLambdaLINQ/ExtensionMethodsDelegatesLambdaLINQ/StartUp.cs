namespace ExtensionMethodsDelegatesLambdaLINQ
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class StartUp
    {
        static void Main(string[] args)
        {
            /* Substring test*/
            StringBuilder str = new StringBuilder("abcdef");
            StringBuilder substringStr = str.Substring(0, 2);   // substring from 0 to 1
            Console.WriteLine(substringStr.ToString());
            Console.WriteLine("-------------------------");

            /* IEnumerable test */
            List<int> list = new List<int>
            {
                1, 3, 5, 7, 21
            };
            int sum = list.Sum<int>();
            Console.WriteLine("sum =  {0}", sum);
            int product = list.Product<int>();
            Console.WriteLine("product =  {0}", product);
            int max = list.MaxElement<int>();
            Console.WriteLine("max = {0}", max);
            int min = list.MinElement<int>();
            Console.WriteLine("min = {0}", min);    // TODO Fix min = 0
            int avg = list.Average<int>();
            Console.WriteLine("avg = {0}", avg);    // TODO Fix avg = 0
            Console.WriteLine("-------------------------");

            /* First before last test */
            Student[] arrayOfStudents = new Student[]
            {
                new Student("Pesho", "Toshev", 72),
                new Student("Pesho", "Goshev", 21),
                new Student("Pesheto", "Peshev", 19),
                new Student("Peneto", "Oshev", 17),
                new Student("Gosho", "Peshev", 32)
            };
            Student[] array = LINQMethods.FirstBeforeLastName(arrayOfStudents);
            foreach (var student in array)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("-------------------------");

            /* Age Range Test*/
            string[] students = LINQMethods.AgeRange(arrayOfStudents);
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("-------------------------");

            /* Order Student */
            array = LINQMethods.OrderStudents(arrayOfStudents);
            foreach (var student in array)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("-------------------------");

            /* Divisible by 7 and 3 */
            LINQMethods.PrintNumsDivisibleBy7And3(list.ToArray());
            Console.WriteLine("-------------------------");

            //  ////////////////////////////////////////  7 and 8

            /* Student groups */
            List<Student> listOfStudents = new List<Student>
            {
                new Student("Name5", "Namov", 34, "1211", "02000s", "Name_@s.com", new List<int> { 5, 6, 4 }, 2, new Group(1, "Math")),
                new Student("Name2", "Namov2", 3, "1211", "000s", "Name_@abv.bg", new List<int> { 5, 6, 4 }, 2, new Group(2, "Sport")),
                new Student("Name3", "Namov3", 4, "1211", "000s", "Ndwte_@s.com", new List<int> { 5, 6, 4 }, 1, new Group(1, "Math")),
                new Student("Name4", "Namov4", 11, "1211", "02000s", "89_@abv.bg", new List<int> { 5, 6, 4 }, 12, new Group(3, "Biology")),
                new Student("Name", "Namov5", 20, "1211", "000s", "Ne_@s.com", new List<int> { 5, 6, 4 }, 2, new Group(1, "Math"))
            };
            Student[] newArrOfStudents = LINQMethods.StudentsGroup(listOfStudents);
            foreach (Student student in newArrOfStudents)
            {
                Console.WriteLine(student.ToStringAll());
            }
            Console.WriteLine("-------------------------");

            //// 10

            /* Extract students by email */
            newArrOfStudents = LINQMethods.ExtractStudentsByEmail(listOfStudents);
            foreach (Student student in newArrOfStudents)
            {
                Console.WriteLine(student.ToStringAll());
            }
            Console.WriteLine("-------------------------");

            /* Extract students by phone */
            newArrOfStudents = LINQMethods.ExtractStudentsByPhone(listOfStudents);
            foreach (Student student in newArrOfStudents)
            {
                Console.WriteLine(student.ToStringAll());
            }
            Console.WriteLine("-------------------------");

            //////// 14, 15

            /* Infinite Convergent Series */
            double precision = 0.001;

            Console.WriteLine("1 + 1/2 + 1/4 + 1/8 + 1/16 + ... = {0:f2}", InfiniteConvergentSeries.ConvergentSum(i => 1.0 / Math.Pow(2, i), precision));
            Console.WriteLine("1 + 1/2! + 1/3! + 1/4! + 1/5! + ... = {0:f2}", InfiniteConvergentSeries.ConvergentSum(i => 1.0 / InfiniteConvergentSeries
                                                                                                                                        .Factorial(i + 1), precision));
            Console.WriteLine("1 + 1/2 - 1/4 + 1/8 - 1/16 + ... = {0:f2}", InfiniteConvergentSeries.ConvergentSum(i => i == 0 ? 1 : -1.0 / Math.Pow(-2, i), precision));
            Console.WriteLine("-------------------------");

            /* Timer */
            TimerDelegate timerDelegate = new TimerDelegate(1, test);
            Console.WriteLine("-------------------------");
        }

        static void test()
        {
            Console.WriteLine("The Method was excexuted at " + DateTime.Now);
        }
    }
}
