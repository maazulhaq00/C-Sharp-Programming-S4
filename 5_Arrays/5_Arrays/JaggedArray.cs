using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Arrays
{
    internal class JaggedArray
    {
        public static void Run()
        {
            int[][] myArray = new int[3][];

            myArray[0] = new int[] { 11, 14, 16 };
            myArray[1] = new int[] { 12, 17 };
            myArray[2] = new int[] { 33, 13, 145, 18 };


            Console.WriteLine(myArray[1][1]); // 17

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write(myArray[i][j] + "  ");
                }
                Console.WriteLine("");
            }
        }
    }
}
