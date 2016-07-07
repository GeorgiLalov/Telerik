namespace SoftwareAcademy.Models
{
    using System;
    using System.Collections.Generic;

    using Interfaces;
    
    public class Teacher : ITeacher
    {
        public Teacher(string name)
        {
            this.Name = name;
            this.Courses = new List<ICourse>();
        }

        public ICollection<ICourse> Courses { get; set; }

        public string Name
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

        public void AddCourse(ICourse course)
        {
            this.Courses.Add(course);
        }
    }
}
