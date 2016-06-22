namespace StudentsWorkers
{
    using System.Collections.Generic;
    using System.Linq;

    public static class LINQMethods
    {
        // sort list by grade in ascending order
        public static List<Student> SortListByGrade(List<Student> listOfStudents)
        {
            List<Student> sortedList = listOfStudents
                                                     .OrderBy(student => student.Grade)
                                                     .ToList();
            return sortedList;   
        }

        // sort list by money per hour in descending order
        public static List<Worker> SortListByMoney(List<Worker> listOfWorkers)
        {
            List<Worker> sortedList = listOfWorkers
                                                     .OrderByDescending(worker => worker.MoneyPerHour())
                                                     .ToList();
            return sortedList;
        }

        // Merge the lists and sort them by first name and last name
        public static List<Human> MergeAndSortByName(List<Student> listOfStudents, List<Worker> listOfWorkers)
        {
            List<Human> listHuman = new List<Human>();
            listHuman.AddRange(listOfStudents);
            listHuman.AddRange(listOfWorkers);
            List<Human> sortListHuman = listHuman
                                                 .OrderBy(human => human.FirstName)
                                                 .ThenBy(human => human.LastName)
                                                 .ToList();
            return sortListHuman;
        }
    }
}
