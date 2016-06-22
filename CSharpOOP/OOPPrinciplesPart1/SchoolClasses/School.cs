namespace SchoolClasses
{
    public class School
    {
        public string Name { get; private set; }
        public Class[] Classes { get; set; }

        public School(string name, Class[] classes)
        {
            this.Name = name;
            this.Classes = classes;
        }
    }
}