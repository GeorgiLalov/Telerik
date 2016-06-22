namespace SchoolClasses
{
    public class Class : ICommentable
    {
        private string comment;

        public string TextID { get; private set; }
        public Student[] Students { get; private set; }
        public Teacher[] Teachers { get; private set; }

        public Class(string textID, Student[] students, Teacher[] teachers)
        {
            this.TextID = textID;
            this.Students = students;
            this.Teachers = teachers;
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