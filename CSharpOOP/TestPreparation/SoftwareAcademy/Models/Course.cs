namespace SoftwareAcademy.Models
{
    using Interfaces;
    using System;

    // TODO: Implement ICourse interface
    public abstract class Course : ICourse
    {
        public Course(string name, ITeacher teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
        }

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

        public ITeacher Teacher
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

        public void AddTopic(string topic)
        {
            throw new NotImplementedException();
        }
    }
}
