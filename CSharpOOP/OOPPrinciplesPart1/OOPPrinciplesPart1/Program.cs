namespace OOPPrinciplesPart1
{
    using System;
    using System.Collections.Generic;
    using StudentsWorkers;
    using AnimalHierarchy;

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>
            {
                new Student("Gosho","Goshev", 5),
                new Student("Pesho","Goshev", 3),
                new Student("Tosho","Goshev", 2),
                new Student("Mosho","Goshev", 6)
            };
            List<Student> newListStudents = LINQMethods.SortListByGrade(studentList);

            foreach (var student in newListStudents)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("--------------------------");

            List<Worker> workerList = new List<Worker>
            {
                new Worker("Mitio", "Goshev", 700, 8),
                new Worker("Pesho", "Toshev", 300, 8),
                new Worker("Momo", "Goshev", 150, 8),
                new Worker("Gogo", "Goshev", 300, 10)
            };
            List<Worker> newListWorker = LINQMethods.SortListByMoney(workerList);
            foreach (var worker in newListWorker)
            {
                Console.WriteLine(worker.ToString());
            }
            Console.WriteLine("--------------------------");

            List<Human> humanList = LINQMethods.MergeAndSortByName(studentList, workerList);
            foreach (var human in humanList)
            {
                Console.WriteLine(human.ToString());
            }
            Console.WriteLine("--------------------------");

            Animal[] animals = 
            {
                new Kitten("Kiti1", 12),
                new Cat("Catt", 10, Gender.Male),
                new Dog("Doge", 5, Gender.Female),
                new Tomcat("Tomy", 2),
                new Frog("Froggy", 3, Gender.Female)
            };

            Console.WriteLine("Avg age = {0}", StaticClass.CalcAvgAge(animals));
            Console.WriteLine("--------------------------");
        }
    }
}
