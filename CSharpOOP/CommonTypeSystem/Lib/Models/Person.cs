namespace Lib.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    public class Person
    {
        public string Name { get; private set; }
        public int? Age { get; set; }

        public Person(string name)
        {
            this.Name = name;
            this.Age = null;
        }

        public Person(string name, int age)
            : this(name)
        {
            this.Age = age;
        }

        public override string ToString()
        {
            StringBuilder strBuild = new StringBuilder();

            strBuild.AppendLine($"Name: {this.Name}");
            if (this.Age == null)
            {
                strBuild.AppendLine("Age not specified");
            }
            else
            {
                strBuild.AppendLine($"Age: {this.Age}");
            }

            return strBuild.ToString();
        }
    }
}
