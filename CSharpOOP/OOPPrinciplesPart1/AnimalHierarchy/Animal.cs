namespace AnimalHierarchy
{
    using System;

    public abstract class Animal : ISound
    {
        private string name;
        private int age;
        private Gender sex;

        public string Name
        {
            get { return this.name; }
            protected set { this.name = value; }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            protected set
            {
                if (value < 0 || value > int.MaxValue)
                {
                    throw new ArgumentException("Age is not valid");
                }
                this.age = value;
            }
        }

        public Gender Sex
        {
            get { return this.sex; }
            protected set { this.sex = value; }
        }

        public abstract void Sound();
    }
}