using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Harry_Potter_4D
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[,,,] hypercube = new string[dimensions[0], dimensions[1], dimensions[2], dimensions[3]];
            dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string harry = "@";
            hypercube[dimensions[0], dimensions[1], dimensions[2], dimensions[3]] = harry; // harry first position

            int basilliskCount = int.Parse(Console.ReadLine());
            for (int count = 0; count < basilliskCount; count++)
            {
                string[] basInput = Console.ReadLine().Split(' ');
                string basName = basInput[0];

                hypercube[int.Parse(basInput[1]), int.Parse(basInput[2]), int.Parse(basInput[3])
                    , int.Parse(basInput[4])] = basName; // basillick position
            }

            Logic(hypercube);
        }

        static void Logic(string[,,,] hypercube)
        {
            string harry = "@";
            string consInstructions;
            int countSteps = 0;

            while ((consInstructions = Console.ReadLine()) != "END")
            {
                string[] consInstrsplit = consInstructions.Split(' ');
                string unitName = consInstrsplit[0];
                string instruction = consInstrsplit[1];
                int coordinateMove = int.Parse(consInstrsplit[2]);

                for (int dimOne = 0; dimOne < hypercube.GetLength(0); dimOne++)
                {
                    for (int dimTwo = 0; dimTwo < hypercube.GetLength(1); dimTwo++)
                    {
                        for (int dimThree = 0; dimThree < hypercube.GetLength(2); dimThree++)
                        {
                            for (int dimFour = 0; dimFour < hypercube.GetLength(3); dimFour++)
                            {
                                if (hypercube[dimOne, dimTwo, dimThree, dimFour] == unitName)
                                {
                                    if (unitName == harry)
                                    {
                                        countSteps++;
                                    }
                                    if (ChangeArray(hypercube, dimOne, dimTwo, dimThree, dimFour, instruction
                                        , coordinateMove, unitName, countSteps))
                                    {
                                        return;
                                    }
                                }
                            }
                        }
                    }
                }// end dimOne for


            }

            Console.WriteLine("@: \"I am the chosen one!\" - {0}", countSteps);
        }

        static bool ChangeArray(string[,,,] hypercube, int dimOne, int dimTwo, int dimThree, int dimFour
            , string instruction, int coordinateMove, string unitName, int countSteps)
        {
            string harry = "@";
            int[] dims = { dimOne, dimTwo, dimThree, dimFour };
            int[] prevDims = { dimOne, dimTwo, dimThree, dimFour };

            int changedDim = instruction.ToCharArray()[0] - 'A';
            if (dims[changedDim] + coordinateMove > hypercube.GetLength(changedDim))
            {
                dims[changedDim] = hypercube.GetLength(0) - 1;
            }
            else
            {
                dims[changedDim] = dims[changedDim] + coordinateMove;
            }

            if (hypercube[dims[0], dims[1], dims[2], dims[3]] == null) // if next cell is empty
            {
                hypercube[dims[0], dims[1], dims[2], dims[3]] = unitName;
                if (hypercube[prevDims[0], prevDims[1], prevDims[2], prevDims[3]].Length == 1) // if is just one basillisk
                {
                    hypercube[prevDims[0], prevDims[1], prevDims[2], prevDims[3]] = null;
                }
                else // if more basillisk remove the current
                {
                    // TODO
                    hypercube[prevDims[0], prevDims[1], prevDims[2], prevDims[3]] = null; // Wrong!!!
                }
            }
            else if (hypercube[dims[0], dims[1], dims[2], dims[3]] == harry)
            {
                Console.WriteLine("{0}: \"You thought you could escape, didn't you?\" - {1}", unitName, countSteps);
                return true;
            }
            else if (hypercube[dims[0], dims[1], dims[2], dims[3]] != null)
            {
                Console.WriteLine("{0}:  \"Step {1} was the worst you ever made.\" {0}:"
                                                        , hypercube[dims[0], dims[1], dims[2], dims[3]], countSteps);
                Console.WriteLine("{0}: \"You will regret until the rest of your life... All 3 seconds of it!\""
                                                        , hypercube[dims[0], dims[1], dims[2], dims[3]]);
                return true;
            }


            return false;
        }
    }
}
