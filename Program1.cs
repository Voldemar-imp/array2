using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numbersArray =
                {
                {4,3,6,9,3,5,7,4,3,9},
                {4,6,6,9,3,5,3,4,3,9},
                {4,3,6,4,3,6,4,5,3,9},
                {4,3,6,9,3,5,7,7,3,8},
                {3,3,6,9,3,3,7,4,3,4},
                {4,4,6,7,3,7,6,6,3,4},
                {4,3,1,9,3,5,7,4,3,4},
                {4,3,6,9,3,5,3,3,9,4},
                {4,3,1,9,3,5,5,4,3,1},
                {4,3,6,9,3,5,7,4,3,1}
                };
            int maxNumber = int.MinValue;

            Console.WriteLine("Исходная матрица");
            for (int i = 0; i < numbersArray.GetLength(0); i++)
            {

                for (int j = 0; j < numbersArray.GetLength(1); j++)
                {
                    Console.Write(numbersArray[i, j] + " ");
                    if (numbersArray[i, j] > maxNumber)
                    {
                        maxNumber = numbersArray[i, j];
                    }
                }

                Console.WriteLine();
            }

            Console.SetCursorPosition(0, numbersArray.GetLength(0) +1);
            Console.WriteLine();
            Console.WriteLine("Наибольший элемент: " + maxNumber);
            Console.WriteLine("Измененная матрица." );
            for (int i = 0; i < numbersArray.GetLength(0); i++)
            {

                for (int j = 0; j < numbersArray.GetLength(1); j++)
                {
                    if (numbersArray[i, j] == maxNumber)
                    {
                        numbersArray[i, j] = 0;
                    }

                    Console.Write(numbersArray[i, j] + " ");                    
                }

                Console.WriteLine();
            }
        }
    }
}
