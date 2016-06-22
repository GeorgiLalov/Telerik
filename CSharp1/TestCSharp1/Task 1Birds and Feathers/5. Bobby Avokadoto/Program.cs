using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Bobby_Avokadoto
{
    class Program
    {
        static void Main(string[] args)
        {
            uint head = uint.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine()); // OK
            uint best = 0;
            int vsCount = 0;
            bool isNoOverlap = true;
            int count1s = 0;
            int preCount1s = 0;

            // head to binary
            uint[] headBinary = new uint[100];
            int countHeadBin = 0;

            do
            {
                headBinary[countHeadBin++] = head % 2;
                head /= 2;
            } while (head != 0);

            // checked OK

            
            for (int i = 0; i < count; i++)
            {
                uint comb = uint.Parse(Console.ReadLine()); 
                uint tempComb = comb; 
                isNoOverlap = true;
                count1s = 0;

                //comb to binary
                uint[] combBinary = new uint[100];
                int countCombBin = 0;
                do
                {
                    combBinary[countCombBin++] = tempComb % 2;
                    tempComb /= 2;
                } while (tempComb != 0);
                // checked OK

                // check 1 and 0
                if (countHeadBin > countCombBin)
                    vsCount = countHeadBin;
                else
                    vsCount = countCombBin;
                for (int y = vsCount - 1; y >= 0; y--)
                {
                    if(combBinary[y] == 1 && headBinary[y] == 1)
                    {
                        isNoOverlap = false;
                        break;
                    }
                }
                // checked OK
                
                if (isNoOverlap)
                {
                    // count 1s
                    for (int y = countCombBin - 1; y >= 0; y--)
                    {
                        if (combBinary[y] == 1)
                            count1s++;
                    }
                    //

                    // check if best 

                    if( count1s > preCount1s)
                    {
                        best = comb;
                        preCount1s = count1s;
                    }
                }
            }


            // print
            Console.WriteLine(best);

        }
    }
}
