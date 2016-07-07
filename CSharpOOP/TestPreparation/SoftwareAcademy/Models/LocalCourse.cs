namespace SoftwareAcademy.Models
{
    using System;
    
    using Interfaces;

    public class LocalCourse : Course, ILocalCourse, ICourse
    {
        public LocalCourse(string name, ITeacher teacher, string lab)
            : base(name, teacher)
        {
            this.Lab = lab;
        }

        public string Lab
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
