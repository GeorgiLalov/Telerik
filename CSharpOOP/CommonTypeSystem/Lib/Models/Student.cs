namespace Lib.Models
{
    using Enumerations;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {
        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }
        public int SSN { get; private set; }
        public string Address { get; private set; }
        public int MobilePhone { get; private set; }
        public string Email { get; private set; }
        public short Course { get; private set; }
        public SpecialtyType Specialty { get; private set; }
        public UniversityType University { get; private set; }
        public FacultyType Faculty { get; private set; }

        public Student(string firstName, string middleName, string lastName, int ssn, string address, int mobilePhone
                        , string email, short course, SpecialtyType specialty, UniversityType university, FacultyType faculty)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MiddleName = middleName;
            this.SSN = ssn;
            this.Address = address;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }

        // TODO Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
