namespace Lib.Tests
{
    using Models;
    using System;

    public static class TestPersonClass
    {
        public static void Test()
        {
            Console.WriteLine("Test Person Classes");
            Console.WriteLine();

            Person firstPerson = new Person("Pesho", 20);
            Person secondPerson = new Person("Gosho");

            Console.WriteLine(firstPerson.ToString());
            Console.WriteLine(secondPerson.ToString());

            Console.WriteLine("..............................................................");
        }
    }
}
