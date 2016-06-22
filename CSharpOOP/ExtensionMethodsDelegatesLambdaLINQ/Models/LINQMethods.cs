using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class LINQMethods
    {
        // from students[] finds all students whose first name is before its last name alphabetically.
        public static Student[] FirstBeforeLastName(Student[] students)
        {
            Student[] returnStudents = students.Where(s => s.FirstName.CompareTo(s.LastName) < 0).ToArray();

            return returnStudents;
        }

        //  finds the first name and last name of all students with age between 18 and 24.
        public static string[] AgeRange(Student[] students)
        {
            string[] result = students
                .Where(student => student.Years >= 18 && student.Years <= 24)
                .Select(student => String.Format("{0}\t{1}", student.FirstName, student.LastName))
                .ToArray();

            return result;
        }

        // sort students by first name and last name in descending order.
        public static Student[] OrderStudents(Student[] students)
        {
            Student[] orderedStudents = students
                .OrderByDescending(student => student.FirstName)
                .ThenByDescending(student => student.LastName)
                .ToArray();

            return orderedStudents;
        }

        //  prints from array of integers all numbers that are divisible by 7 and 3
        public static void PrintNumsDivisibleBy7And3(int[] array)
        {
            int[] nums = array.Where(x => x % 7 == 0 && x % 3 == 0).ToArray();

            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
        }

        // Selects only the students that are from group number 2. Order students by FirstName.
        public static Student[] StudentsGroup(List<Student> students)
        {
            Student[] result = students
                                    .Where(s => s.GroupNumber == 2)
                                    .OrderBy(s => s.FirstName)
                                    .ToArray();
            return result;
        }

        // Extract all students that have email in abv.bg
        public static Student[] ExtractStudentsByEmail(List<Student> students)
        {
            Student[] result = students
                                    .Where(s => s.Email.Substring(s.Email.Length - 6).Equals("abv.bg"))
                                    .ToArray();
            return result;
        }

        // Extract all students that have phones in Sofia
        public static Student[] ExtractStudentsByPhone(List<Student> students)
        {
            Student[] result = students
                                    .Where(s => s.Telephone.Substring(0, 2).Equals("02"))
                                    .ToArray();
            return result;
        }

        
    }
}
