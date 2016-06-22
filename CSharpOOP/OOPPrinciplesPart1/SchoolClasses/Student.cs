namespace SchoolClasses
{
    using System;

    public class Student : Human, ICommentable
    {
        private int classNumber;
        private string comment;

        public Student(string firstName, string lastName, int classNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.ClassNumber = classNumber;
        }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            private set
            {
                if (value < 0 && value > int.MaxValue)
                {
                    throw new ArgumentException("Class number is not valid!");
                }
                this.classNumber = value;
            }
        }

        string ICommentable.Comment
        {
            get
            {
                return this.comment;
            }

            set
            {
                this.comment = value;
            }
        }
        
    }
}