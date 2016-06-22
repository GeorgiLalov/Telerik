namespace Models
{
    using System.Collections.Generic;

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Years { get; set; }
        public string FN { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public int GroupNumber { get; set; }
        public Group Group { get; set; }

        public Student(string firstName, string lastName, int years)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Years = years;
        }

        public Student(string firstName, string lastName, int years, string fn, string telephone, string email,
            List<int> marks, int groupNumber, Group group)
            : this(firstName, lastName, years)
        {
            this.FN = fn;
            this.Telephone = telephone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
            this.Group = group;
        }

        public override string ToString()
        {
            return $"{this.FirstName}\t{this.LastName}\t{this.Years}";
        }

        public string ToStringAll()
        {
            return $"{this.FirstName}\t{this.LastName}\t{this.Years}\t{this.FN}\t{this.Telephone}\t{this.Email}\t{this.GroupNumber}\t{this.Group.ToString()}";
        }
    }
}
