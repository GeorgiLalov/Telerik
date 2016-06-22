namespace SchoolClasses
{
    using System;

    public class Dispicline : ICommentable
    {
        private int numberOfLecturers;
        private int numberOfExercise;
        private string comment;

        public Dispicline(string name, int numberOfLecturers, int numberOfExercise)
        {
            this.Name = name;
            this.NumberOfLecturers = numberOfLecturers;
            this.NumberOfExercise = numberOfExercise;
        }

        public string Name { get; private set; }

        public int NumberOfLecturers
        {
            get { return this.numberOfLecturers; }
            private set
            {
                if (value < 0 && value > int.MaxValue)
                {
                    throw new ArgumentException("Number of Lecturers is not valid!");
                }
                numberOfLecturers = value;
            }
        }

        public int NumberOfExercise
        {
            get { return this.numberOfExercise; }
            private set
            {
                if (value < 0 && value > int.MaxValue)
                {
                    throw new ArgumentException("Number of Exercise is not valid!");
                }
                numberOfExercise = value;
            }
        }

        public string Comment
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