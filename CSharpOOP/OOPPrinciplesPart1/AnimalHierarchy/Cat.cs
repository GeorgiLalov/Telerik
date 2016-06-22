namespace AnimalHierarchy
{
    using System;

    public class Cat : Animal
    {
        public Cat(string name, int age, Gender sex)
            : this(name, age)
        {
            this.Sex = sex;
        }

        public Cat(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override void Sound()
        {
            Console.WriteLine("MiayMiay!");
        }
    }
}