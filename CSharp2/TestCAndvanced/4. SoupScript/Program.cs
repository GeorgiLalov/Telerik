using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.SoupScript
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int openBrackets = 0;
            StringBuilder[] strBuild = new StringBuilder[n];
            for (int i = 0; i < n; i++)
            {
                strBuild[i] = new StringBuilder();
            }

            for (int count = 0; count < n; count++)
            {
                string[] splitLine = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                if (openBrackets != 0)
                {
                    strBuild[count].Append(new string(' ', openBrackets * 4));
                }

                if (splitLine.Contains("{"))
                {
                    openBrackets++;
                }
                else if (splitLine.Contains("}"))
                {
                    openBrackets--;    
                    strBuild[count].Remove(0, 4);   
                }

                // for every word
                for (int wordIndex = 0; wordIndex < splitLine.Length; wordIndex++)
                {
                    strBuild[count].Append(splitLine[wordIndex]);
                    strBuild[count].Append(' ');
 
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(strBuild[i]);
            }
        }
    }
}
