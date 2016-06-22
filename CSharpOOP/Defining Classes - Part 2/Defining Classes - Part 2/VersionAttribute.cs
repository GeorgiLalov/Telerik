namespace Defining_Classes___Part_2
{
    using System;

    class VersionAttribute : Attribute
    {
        public int Major { get; private set; }
        public int Minor { get; private set; }

        public VersionAttribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }

        public override string ToString()
        {
            return $"version: {this.Major}.{this.Minor}";
        }
    }
}
