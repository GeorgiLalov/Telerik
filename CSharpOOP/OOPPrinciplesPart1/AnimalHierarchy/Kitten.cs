namespace AnimalHierarchy
{
    using System;

    public class Kitten : Cat
    {
        public Kitten(string name, int age) : base(name, age)
        {
            this.Sex = Gender.Female;
        }

        public override void Sound()
        {
            Console.WriteLine("Kitten sound");
        }
    }
}