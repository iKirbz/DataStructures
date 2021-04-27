using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplaySigleDimensionalArrays();

            DisplayMultiDimensionalArrays();

            DisplayJaggedArrays();

            Console.ReadLine();
        }
        
        private static void DisplaySigleDimensionalArrays()
        {
            //SingleDimensionale Arrays

            int[] array1 = new int[3];

            array1[0] = 1;
            array1[1] = 2;
            array1[2] = 3;

            int[] array2 = new int[] { 1, 2, 3 };

            int[] array3 = { 1, 2, 3 };


            Console.WriteLine("Single-Dimensional Arrays:");
            Console.WriteLine(String.Join(", ", array1));

            Console.WriteLine("\n");
        }

        private static void DisplayMultiDimensionalArrays()
        {
            //Multi-Dimensionale Arrays

            int[,] array2D_1 = new int[3, 2];

            array2D_1[0, 0] = 1;
            array2D_1[0, 1] = 2;

            array2D_1[1, 0] = 3;
            array2D_1[1, 1] = 4;

            array2D_1[2, 0] = 5;
            array2D_1[2, 1] = 6;

            int[,] array2D_2 = new int[2, 2] { { 1, 2 }, { 3, 4 } };

            int[,] array2D_3 = { { 1, 2 }, { 3, 4 } };


            Console.WriteLine("Multi-Dimensional Arrays:\n");
            Console.WriteLine($"The array has {array2D_1.Rank} dimensions.");

            for (int x = 0; x < array2D_1.GetLength(0); x++)
            {
                for (int y = 0; y < array2D_1.GetLength(1); y++)
                {
                    Console.Write($"{array2D_1[x, y]}, ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\n");
        }

        private static void DisplayJaggedArrays()
        {
            //Jagged Arrays

            int[][] jagged_array = new int[2][];

            jagged_array[0] = new int[] { 1, 2 };
            jagged_array[1] = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Jagged Arrays:");

            foreach (var array in jagged_array)
            {
                Console.WriteLine(String.Join(", ", array));
            }
        }
    }
}
