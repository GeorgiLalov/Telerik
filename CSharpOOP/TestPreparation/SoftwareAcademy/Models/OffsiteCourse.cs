namespace SoftwareAcademy.Models
{
    using System;

    using Interfaces;

    public class OffsiteCourse : Course, IOffsiteCourse, ICourse
    {
        public OffsiteCourse(string name, ITeacher teacher, string town) 
            : base(name, teacher)
        {
            this.Town = town;
        }

        public string Town
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
