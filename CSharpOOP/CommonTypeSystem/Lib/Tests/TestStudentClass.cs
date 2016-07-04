namespace Lib.Tests
{
    using Enumerations;
    using Models;
    using System;

    public static class TestStudentClass
    {
        public static void Test()
        {
            Console.WriteLine("Test Student Class");

            Student student = new Student("Gosho", "Toshev", "Goshev", 133217, "ul. Shtipka 19", 123458, "GoshoGoshev@mail.bg", 2, SpecialtyType.FirstSpecialty
                                                                                                            , UniversityType.FirstUniversity, FacultyType.FirstFaculty);
            Console.WriteLine(student);
            Console.WriteLine();

            Console.WriteLine("Cloned Student:");

            Student clonedStudent = (Student)student.Clone();
            Console.WriteLine(clonedStudent);

            Console.WriteLine("Are they equal:");
            Console.WriteLine(clonedStudent == student);

            clonedStudent.Course = 1;
            Console.WriteLine(clonedStudent == student);
            Console.WriteLine();

            Console.WriteLine("Student HashCode: {0}", student.GetHashCode());
            Console.WriteLine("Changed cloned Student HashCode: {0}", clonedStudent.GetHashCode());

            Console.WriteLine("..............................................................");
        }
    }
}
