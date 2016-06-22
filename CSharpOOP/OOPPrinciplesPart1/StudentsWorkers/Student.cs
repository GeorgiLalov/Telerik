namespace StudentsWorkers
{
    using System;
    
    public class Student : Human
    {
        private int grade;

        public Student(string firstName, string lastName, int grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }
            private set
            {
                if (value < 0 && value > int.MaxValue)
                {
                    throw new ArgumentException("Grade argument exception!");
                }
                this.grade = value;
            }
        }

        public override string ToString()
        {
            return $"{this.FirstName}\t{this.LastName}\t{this.Grade}";
        }
    }
}
