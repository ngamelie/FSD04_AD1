using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day01ArraysAndLists
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                // possibly a jagged array, only the first dimension is allocated
                int[][] twoDimInt = new int[4][];
                // rectangular array
                int[,] twoDimIntRectangular = new int[4, 3];
                int[,,] threeDimIntRect = new int[4, 3, 2]; // 3D: 4 x 3 x 2 size

                int[,] data2dInts = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 18 } };

                float sum = 0;

                // use a two for loop
                for (int i = 0; i < data2dInts.GetLength(0); i++)
                {
                    for (int j = 0; j < data2dInts.GetLength(1); j++) // for column
                    {
                        sum += data2dInts[i, j];
                    }
                }
                //Console.WriteLine("The average value of all values in data2dIns is {0}", sum / data2dInts.Length);
                double avg = sum / data2dInts.Length;
                Console.WriteLine($"The average value of all values in data2dIns is {avg:0.0##}");

                
                { // use a foreach loop
                    double sum1 = 0;
                    foreach(int val in data2dInts)
                    {
                        sum1 += val;
                    }
                    double avg1 = sum / data2dInts.Length;
                    Console.WriteLine($"The average value of all values in data2dIns is {avg1:0.0##}");
                }
            }
           
            finally
            {
                Console.WriteLine("Press any key to finish");
                Console.ReadLine();
            }            
        }
    }
}
