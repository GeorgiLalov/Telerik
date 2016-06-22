namespace AnimalHierarchy
{
    using System;

    public class Tomcat : Cat
    {
        public Tomcat(string name, int age) : base(name, age)
        {
            this.Sex = Gender.Male;
        }

        public override void Sound()
        {
            Console.WriteLine("Tomcat sound");
        }
    }
}