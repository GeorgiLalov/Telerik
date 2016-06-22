namespace AnimalHierarchy
{
    using System;

    public class Dog : Animal
    {
        public Dog(string name, int age, Gender sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public override void Sound()
        {
            Console.WriteLine("BauBau!");
        }
    }
}