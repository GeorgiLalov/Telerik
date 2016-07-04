namespace Lib.Models
{
    using Enumerations;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student : ICloneable, IComparable<Student>
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int SSN { get; set; }
        public string Address { get; set; }
        public int MobilePhone { get; set; }
        public string Email { get; set; }
        public short Course { get; set; }
        public SpecialtyType Specialty { get; set; }
        public UniversityType University { get; set; }
        public FacultyType Faculty { get; set; }

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
        
        public override bool Equals(object obj)
        {
            // If parameter is null return false.
            if (obj == null)
            {
                return false;
            }

            // If parameter cannot be cast to Student return false.
            Student student = obj as Student;
            if (student == null)
            {
                return false;
            }

            // Return true if the fields match:
            return (this.FirstName == student.FirstName) && (this.MiddleName == student.MiddleName) && (this.LastName == student.LastName) &&
                (this.SSN == student.SSN) && (this.Address == student.Address) && (this.MobilePhone == student.MobilePhone) &&
                (this.Email == student.Email) && (this.Course == student.Course) && (this.Specialty == student.Specialty) &&
                (this.University == student.University) && (this.Faculty == student.Faculty);
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return firstStudent.Equals(secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !(firstStudent.Equals(secondStudent));
        }

        public override int GetHashCode()
        {
            int prime = 13;
            int hash = 1;

            hash = (hash * prime) + this.FirstName.GetHashCode();
            hash = (hash * prime) + this.MiddleName.GetHashCode();
            hash = (hash * prime) + this.LastName.GetHashCode();
            hash = (hash * prime) + this.SSN;
            hash = (hash * prime) + this.Address.GetHashCode();
            hash = (hash * prime) + this.MobilePhone;
            hash = (hash * prime) + this.Email.GetHashCode();
            hash = (hash * prime) + this.Course;
            hash = (hash * prime) + (int)this.Specialty;
            hash = (hash * prime) + (int)this.University;
            hash = (hash * prime) + (int)this.Faculty;

            return hash;
        }

        public override string ToString()
        {
            StringBuilder strBuild = new StringBuilder();

            strBuild.AppendLine($"Name: {this.FirstName} {this.MiddleName} {this.LastName}");
            strBuild.AppendLine($"SSN: {this.SSN} Address: {this.Address} MobilePhone: {this.MobilePhone} Email: {this.Email}");
            strBuild.AppendLine($"Course: {this.Course} Specialty: {this.Specialty} University: {this.University} Faculty: {this.Faculty}");

            return strBuild.ToString();
        }

        public object Clone()
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Address, this.MobilePhone, this.Email, this.Course
                                                                        , this.Specialty, this.University, this.Faculty);
        }

        public int CompareTo(Student other)
        {
            int compare = 0;

            compare = this.FirstName.CompareTo(other.FirstName);

            if (compare == 0)
            {
                compare = this.MiddleName.CompareTo(other.MiddleName);

                if (compare == 0)
                {
                    compare = this.LastName.CompareTo(other.LastName);

                    if (compare == 0)
                    {
                        compare = this.SSN.CompareTo(other.SSN);
                    }
                }
            }

            return compare;
        }
    }
}
