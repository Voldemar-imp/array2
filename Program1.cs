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
            int linesNumber = 10;
            int columnsNumber = 10;
            int[,] numbersArray = new int[linesNumber, columnsNumber];
            int randomMin = 1;
            int randomMax = 9;
            Random random = new Random();
            int maxNumber = int.MinValue;

            Console.WriteLine("Исходная матрица");
            
            for (int i = 0; i < numbersArray.GetLength(0); i++)
            {
                for (int j = 0; j < numbersArray.GetLength(1); j++)
                {
                    numbersArray[i, j] = random.Next(randomMin, randomMax +1);
                    Console.Write(numbersArray[i, j] + " ");
                    
                    if (numbersArray[i, j] > maxNumber)
                    {
                        maxNumber = numbersArray[i, j];
                    }
                }

                Console.WriteLine();
            }

            Console.SetCursorPosition(0, numbersArray.GetLength(0));
            Console.WriteLine("\n\nНаибольший элемент: " + maxNumber);
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
