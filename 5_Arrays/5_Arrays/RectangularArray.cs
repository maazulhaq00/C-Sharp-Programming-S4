using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Arrays
{
    class RectangularArray
    {
        public static void Run()
        {
            // rectangular multi dimension array

            int[,] matrix = new int[3, 4] {
                {22, 56, 7, 4 },
                {15, 81, 13, 5 },
                {54, 23, 45, 19 }
            };

            matrix[0, 0] = 15;

            Console.WriteLine(matrix.Length); // 12
            Console.WriteLine(matrix.GetLength(0)); // 3
            Console.WriteLine(matrix.GetLength(1)); // 4

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + "  ");
                }
                Console.WriteLine("");
            }

        }

    }
}
