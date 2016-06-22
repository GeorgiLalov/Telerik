namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class StringBuilderExtensionMethods
    {
        // substring from begin to lenght - 1 , return new StringBuilder 
        public static StringBuilder Substring(this StringBuilder builder, int begin, int length)
        {
            Console.WriteLine("Substring Extension");

            StringBuilder result = new StringBuilder();

            result.Append(builder.ToString(), begin, length);

            return result;
        }


    }
}
