namespace SchoolClasses
{
    public class Teacher : Human, ICommentable
    {
        private string comment;

        public Teacher(string firstName, string lastName, Dispicline[] disciplines)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Disciplines = disciplines;
        }

        public Dispicline[] Disciplines { get; private set; }

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